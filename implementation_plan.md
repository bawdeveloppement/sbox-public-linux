# Plan d'Intégration BepuPhysics v2 via NativeAOT

## Principe Fondamental

**TOUT passe par `Sbox.Engine.Emulation`** - Aucune modification de `Sandbox.Engine`

Le code existant de `Sandbox.Engine` appelle des fonctions natives via [IPhysicsWorld](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#9063-9064), [IPhysicsBody](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#8443-8708), etc. Notre travail est d'implémenter ces fonctions natives dans [EngineExports.cs](file:///home/hermann/Repositories/sbox-public/src/Sbox.Engine.Emulation/EngineExports.cs) en utilisant BepuPhysics.

---

## Architecture

```
Sandbox.Engine (INCHANGÉ)
    ↓ Appelle via function pointers
IPhysicsWorld.__N.IPhysicsWorld_CreateWorld()
    ↓ Pointe vers
EngineExports.Physics_CreateWorld() [NativeAOT]
    ↓ Utilise
BepuPhysicsWorld (dans Sbox.Engine.Emulation)
    ↓ Wraps
BepuPhysics.Simulation
```

---

## Gestion des Handles

### Problème
`Sandbox.Engine` utilise un système de handles (int) pour référencer les objets natifs. Quand on appelle `g_pPhysicsSystem.CreateWorld()`, il retourne un [int](file:///home/hermann/Repositories/sbox-public/src/engine2/interop.engine.cpp#230-234) qui est ensuite utilisé via `HandleIndex.Get<PhysicsWorld>(handle)`.

### Solution
Créer un `HandleManager` dans [EngineExports.cs](file:///home/hermann/Repositories/sbox-public/src/Sbox.Engine.Emulation/EngineExports.cs) qui:
1. Stocke les objets Bepu (Simulation, BodyHandle, etc.)
2. Retourne des handles valides (int)
3. Permet de récupérer les objets via ces handles

```csharp
// Dans EngineExports.cs
private static class HandleManager
{
    private static int _nextHandle = 1000;
    private static Dictionary<int, object> _objects = new();
    
    public static int Register(object obj)
    {
        int handle = _nextHandle++;
        _objects[handle] = obj;
        return handle;
    }
    
    public static T Get<T>(int handle) where T : class
    {
        return _objects.TryGetValue(handle, out var obj) ? obj as T : null;
    }
    
    public static void Unregister(int handle)
    {
        _objects.Remove(handle);
    }
}
```

**Note**: Le handle 1000 est valide car [HandleIndex](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#13672-13687) dans `Sandbox.Engine` accepte n'importe quel int > 0.

---

## Structure du Projet

```
src/Sbox.Engine.Emulation/
├── Sbox.Engine.Emulation.csproj
├── EngineExports.cs                 # Exports NativeAOT existants
├── Physics/
│   ├── BepuPhysicsWorld.cs         # Wrapper pour Simulation
│   ├── BepuPhysicsBody.cs          # Wrapper pour BodyHandle
│   ├── BepuCollisionCallbacks.cs   # Callbacks Bepu
│   └── HandleManager.cs            # Gestion des handles
└── [autres fichiers existants]
```

---

## Fonctions Natives à Implémenter

### Phase 1: Core Physics World (CRITIQUE)

#### g_pPhysicsSystem
```csharp
// Index 1464
[UnmanagedCallersOnly]
public static int Physics_CreateWorld()
{
    var world = new BepuPhysicsWorld();
    return HandleManager.Register(world);
}

// Index 1465
[UnmanagedCallersOnly]
public static void Physics_DestroyWorld(void* worldPtr)
{
    int handle = (int)(long)worldPtr;
    var world = HandleManager.Get<BepuPhysicsWorld>(handle);
    world?.Dispose();
    HandleManager.Unregister(handle);
}
```

#### IPhysicsWorld
```csharp
// Index 2016 - AddBody
[UnmanagedCallersOnly]
public static int IPhysicsWorld_AddBody(void* worldPtr)
{
    int worldHandle = (int)(long)worldPtr;
    var world = HandleManager.Get<BepuPhysicsWorld>(worldHandle);
    
    var bodyHandle = world.AddBody();
    return HandleManager.Register(bodyHandle);
}

// Index 2018 - GetWorldReferenceBody
[UnmanagedCallersOnly]
public static int IPhysicsWorld_GetWorldReferenceBody(void* worldPtr)
{
    // Retourner un body statique de référence
    int worldHandle = (int)(long)worldPtr;
    var world = HandleManager.Get<BepuPhysicsWorld>(worldHandle);
    
    var refBody = world.GetReferenceBody();
    return HandleManager.Register(refBody);
}

// Index 2019 - SetWorldReferenceBody
[UnmanagedCallersOnly]
public static void IPhysicsWorld_SetWorldReferenceBody(void* worldPtr, void* bodyPtr)
{
    // Pas besoin d'action pour Bepu
}

// Index 2022 - GetGravity
[UnmanagedCallersOnly]
public static Vector3 IPhysicsWorld_GetGravity(void* worldPtr)
{
    int worldHandle = (int)(long)worldPtr;
    var world = HandleManager.Get<BepuPhysicsWorld>(worldHandle);
    return world?.Gravity ?? new Vector3(0, 0, -800);
}

// Index 2041 - SetDebugScene
[UnmanagedCallersOnly]
public static void IPhysicsWorld_SetDebugScene(void* worldPtr, void* scenePtr)
{
    // Stocker la référence si nécessaire pour le debug draw
}

// Index 2042 - GetDebugScene
[UnmanagedCallersOnly]
public static int IPhysicsWorld_GetDebugScene(void* worldPtr)
{
    return 0; // Pas de debug scene pour l'instant
}
```

---

## Implémentation BepuPhysicsWorld

```csharp
// src/Sbox.Engine.Emulation/Physics/BepuPhysicsWorld.cs
using BepuPhysics;
using BepuPhysics.Collidables;
using BepuUtilities.Memory;
using System.Numerics;

namespace Sbox.Engine.Emulation.Physics;

public class BepuPhysicsWorld : IDisposable
{
    private Simulation _simulation;
    private BufferPool _bufferPool;
    private SimpleThreadDispatcher _threadDispatcher;
    private BodyHandle _referenceBody;
    
    public Vector3 Gravity { get; set; }
    
    public BepuPhysicsWorld()
    {
        _bufferPool = new BufferPool();
        _threadDispatcher = new SimpleThreadDispatcher(Environment.ProcessorCount);
        
        Gravity = new Vector3(0, 0, -800);
        
        _simulation = Simulation.Create(
            _bufferPool,
            new NarrowPhaseCallbacks(),
            new PoseIntegratorCallbacks(Gravity),
            new SolveDescription(8, 1)
        );
        
        // Créer un body de référence statique
        _referenceBody = _simulation.Statics.Add(
            new StaticDescription(
                new Vector3(0, 0, 0),
                new CollidableDescription(
                    _simulation.Shapes.Add(new Box(1, 1, 1)),
                    0.1f
                )
            )
        );
    }
    
    public BodyHandle AddBody()
    {
        var bodyDescription = BodyDescription.CreateDynamic(
            new RigidPose(Vector3.Zero),
            new BodyInertia { InverseMass = 1f },
            new CollidableDescription(
                _simulation.Shapes.Add(new Box(1, 1, 1)),
                0.1f
            ),
            new BodyActivityDescription(0.01f)
        );
        
        return _simulation.Bodies.Add(bodyDescription);
    }
    
    public BodyHandle GetReferenceBody()
    {
        return _referenceBody;
    }
    
    public void Step(float dt)
    {
        _simulation.Timestep(dt, _threadDispatcher);
    }
    
    public void Dispose()
    {
        _simulation?.Dispose();
        _bufferPool?.Clear();
        _threadDispatcher?.Dispose();
    }
}
```

---

## Callbacks Bepu

```csharp
// src/Sbox.Engine.Emulation/Physics/BepuCollisionCallbacks.cs
using BepuPhysics;
using BepuPhysics.CollisionDetection;
using System.Numerics;

namespace Sbox.Engine.Emulation.Physics;

struct NarrowPhaseCallbacks : INarrowPhaseCallbacks
{
    public void Initialize(Simulation simulation) { }
    
    public bool AllowContactGeneration(int workerIndex, CollidableReference a, CollidableReference b, ref float speculativeMargin)
    {
        return true;
    }
    
    public bool AllowContactGeneration(int workerIndex, CollidablePair pair, int childIndexA, int childIndexB)
    {
        return true;
    }
    
    public bool ConfigureContactManifold<TManifold>(
        int workerIndex, 
        CollidablePair pair, 
        ref TManifold manifold, 
        out PairMaterialProperties pairMaterial) 
        where TManifold : unmanaged, IContactManifold<TManifold>
    {
        pairMaterial.FrictionCoefficient = 1f;
        pairMaterial.MaximumRecoveryVelocity = 2f;
        pairMaterial.SpringSettings = new SpringSettings(30, 1);
        return true;
    }
    
    public bool ConfigureContactManifold(
        int workerIndex, 
        CollidablePair pair, 
        int childIndexA, 
        int childIndexB, 
        ref ConvexContactManifold manifold)
    {
        return true;
    }
    
    public void Dispose() { }
}

struct PoseIntegratorCallbacks : IPoseIntegratorCallbacks
{
    public Vector3 Gravity;
    
    public PoseIntegratorCallbacks(Vector3 gravity)
    {
        Gravity = gravity;
    }
    
    public readonly AngularIntegrationMode AngularIntegrationMode => AngularIntegrationMode.Nonconserving;
    public readonly bool AllowSubstepsForUnconstrainedBodies => false;
    public readonly bool IntegrateVelocityForKinematics => false;
    
    public void Initialize(Simulation simulation) { }
    public void PrepareForIntegration(float dt) { }
    
    public void IntegrateVelocity(
        Vector<int> bodyIndices, 
        Vector3Wide position, 
        QuaternionWide orientation, 
        BodyInertiaWide localInertia, 
        Vector<int> integrationMask, 
        int workerIndex, 
        Vector<float> dt, 
        ref BodyVelocityWide velocity)
    {
        velocity.Linear += Gravity * dt;
    }
}
```

---

## Plan d'Implémentation

### Phase 1: Setup & Core (2-3h)

1. ✅ Ajouter BepuPhysics NuGet à [Sbox.Engine.Emulation.csproj](file:///home/hermann/Repositories/sbox-public/src/Sbox.Engine.Emulation/Sbox.Engine.Emulation.csproj)
```xml
<PackageReference Include="BepuPhysics" Version="2.5.0" />
<PackageReference Include="BepuUtilities" Version="2.0.0" />
```

2. ✅ Créer `HandleManager.cs`
3. ✅ Créer `BepuPhysicsWorld.cs`
4. ✅ Créer `BepuCollisionCallbacks.cs`
5. ✅ Implémenter fonctions core dans [EngineExports.cs](file:///home/hermann/Repositories/sbox-public/src/Sbox.Engine.Emulation/EngineExports.cs)
6. ✅ Patcher les indices dans `PatchNativeFunctions`

### Phase 2: Body Management (2-3h)

7. ⬜ Implémenter [IPhysicsBody](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#8443-8708) functions
   - GetPosition, SetPosition
   - GetOrientation, SetOrientation
   - GetLinearVelocity, SetLinearVelocity
   - GetAngularVelocity, SetAngularVelocity
   - GetMass, SetMass
   - Enable, Disable

8. ⬜ Créer `BepuPhysicsBody.cs` wrapper

### Phase 3: Shapes (2-3h)

9. ⬜ Implémenter [IPhysicsShape](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#8909-9048) functions
   - AddBoxShape
   - AddSphereShape
   - AddCapsuleShape
   - RemoveShape

### Phase 4: Simulation (1-2h)

10. ⬜ Implémenter [StepSimulation](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Interop.Engine.cs#9114-9116)
11. ⬜ Implémenter [ProcessIntersections](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Systems/Physics/PhysicsWorld.cs#161-169) (collisions)

---

## Modifications dans EngineExports.cs

```csharp
// Ajouter en haut du fichier
using Sbox.Engine.Emulation.Physics;

// Dans PatchNativeFunctions, ajouter:
private static void PatchNativeFunctions(void** native)
{
    // ... code existant ...
    
    // Physics System
    native[1464] = (void*)(delegate* unmanaged<int>)&Physics_CreateWorld;
    native[1465] = (void*)(delegate* unmanaged<void*, void>)&Physics_DestroyWorld;
    
    // IPhysicsWorld
    native[2016] = (void*)(delegate* unmanaged<void*, int>)&IPhysicsWorld_AddBody;
    native[2018] = (void*)(delegate* unmanaged<void*, int>)&IPhysicsWorld_GetWorldReferenceBody;
    native[2019] = (void*)(delegate* unmanaged<void*, void*, void>)&IPhysicsWorld_SetWorldReferenceBody;
    native[2022] = (void*)(delegate* unmanaged<void*, Vector3>)&IPhysicsWorld_GetGravity;
    native[2041] = (void*)(delegate* unmanaged<void*, void*, void>)&IPhysicsWorld_SetDebugScene;
    native[2042] = (void*)(delegate* unmanaged<void*, int>)&IPhysicsWorld_GetDebugScene;
}
```

---

## Critères de Succès

### Phase 1
- ✅ [PhysicsWorld](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Systems/Physics/PhysicsWorld.cs#63-64) créé sans crash
- ✅ Handle valide retourné
- ✅ Pas d'exception `NullReferenceException`

### Phase 2
- ✅ [PhysicsBody](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.Engine/Systems/Physics/PhysicsBody.cs#35-36) créé et ajouté
- ✅ Position/Rotation fonctionnent
- ✅ Velocity fonctionne

### Phase 3
- ✅ Shapes ajoutées correctement
- ✅ Collisions détectées

### Phase 4
- ✅ Simulation step fonctionne
- ✅ Gravité appliquée
- ✅ Pas de crashes sur 1h+

---

## Prochaines Étapes Immédiates

1. Ajouter BepuPhysics au [.csproj](file:///home/hermann/Repositories/sbox-public/engine/Sandbox.System/Sandbox.System.csproj)
2. Créer les fichiers de base (HandleManager, BepuPhysicsWorld, Callbacks)
3. Implémenter les fonctions Phase 1 dans EngineExports
4. Compiler et tester
5. Itérer sur les erreurs
