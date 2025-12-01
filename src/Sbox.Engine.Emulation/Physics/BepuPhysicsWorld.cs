using BepuPhysics;
using BepuPhysics.Collidables;
using BepuUtilities.Memory;
using BepuPhysics;
using BepuUtilities;
using System.Numerics;

namespace Sbox.Engine.Emulation.Physics;

/// <summary>
/// Wrapper around BepuPhysics Simulation. Provides methods used by the NativeAOT exports.
/// </summary>
public class BepuPhysicsWorld : IDisposable
{
    private readonly BufferPool _bufferPool;
    private readonly IThreadDispatcher? _threadDispatcher;
    public Simulation Simulation { get; private set; }
    private BodyHandle _referenceBody;

    public Vector3 Gravity { get; set; } = new Vector3(0, 0, -800);

    public BepuPhysicsWorld()
    {
        _bufferPool = new BufferPool();
        _threadDispatcher = null; // Utilisation single-thread par défaut
        // Initialise simulation with default callbacks.
        Simulation = Simulation.Create(
            _bufferPool,
            new NarrowPhaseCallbacks(),
            new PoseIntegratorCallbacks(Gravity),
            new SolveDescription(8, 1)
        );
        // Crée un body statique de référence (StaticHandle)
        var boxIndex = Simulation.Shapes.Add(new Box(1, 1, 1));
        var staticDesc = new StaticDescription(
            new RigidPose(new Vector3(0, 0, 0)),
            boxIndex
        );
        var staticHandle = Simulation.Statics.Add(staticDesc);
        _referenceBody = default; // Pas de BodyHandle pour statique, à adapter selon usage
    }

    /// <summary>
    /// Adds a dynamic body with a simple box shape. In a full implementation this would be more flexible.
    /// </summary>
    public BodyHandle AddBody()
    {
        var bodyDesc = BodyDescription.CreateDynamic(
            new RigidPose(Vector3.Zero),
            new BodyInertia { InverseMass = 1f },
            new CollidableDescription(Simulation.Shapes.Add(new Box(1, 1, 1)), 0.1f),
            new BodyActivityDescription(0.01f)
        );
        return Simulation.Bodies.Add(bodyDesc);
    }

    public BodyHandle GetReferenceBody() => _referenceBody;
    // Si besoin d'un handle statique, exposer StaticHandle

    public void Step(float dt)
    {
        Simulation?.Timestep(dt, _threadDispatcher);
    }

    public void Dispose()
    {
        Simulation?.Dispose();
        _bufferPool?.Clear();
    }
}
