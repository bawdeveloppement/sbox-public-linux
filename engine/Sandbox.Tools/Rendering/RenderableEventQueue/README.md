# RenderableEventQueue Library

Librairie modulaire pour optimiser le rendu en utilisant un système de queue d'événements et de cache GPU.

## Architecture

### Principe
- **Queue = 0** : Utiliser la dernière frame en cache (pas de rendu)
- **Queue = 1** : Rendre et sauvegarder en cache GPU
- **Queue > 1** : Rendre sans sauvegarder (trop de changements)

## Composants

### 1. `RenderableEvent`
Événement qui indique qu'un rendu est nécessaire.

**Types d'événements :**
- `SceneObjectChanged` - GameObject transform/property changed
- `CameraMoved` - Camera position/rotation changed
- `MaterialChanged` - Material/property changed
- `SelectionChanged` - Selection changed in editor
- `GizmoInteraction` - User interacting with gizmo
- `AnimationFrame` - Animation playing
- `LightingChanged` - Light/lighting changed
- `PostProcessChanged` - Post-processing changed
- `Custom` - Custom event

### 2. `RenderableEventQueue`
Queue globale thread-safe pour tracker les événements.

**Fonctionnalités :**
- Thread-safe
- Déduplication automatique des événements récents
- Limite de taille configurable
- Méthodes pour consulter/vider la queue

### 3. `RenderCacheManager`
Gestionnaire de cache GPU pour les frames rendues.

**Fonctionnalités :**
- Création/mise à jour de textures de cache
- Validation/invalidation du cache
- Gestion de la mémoire GPU

### 4. `RenderableEventEmitter`
Classe utilitaire pour émettre des événements facilement.

**Méthodes :**
- `EmitSceneObjectChanged(object source)`
- `EmitCameraMoved(object camera)`
- `EmitMaterialChanged(object material)`
- `EmitSelectionChanged(object selection)`
- `EmitGizmoInteraction(object gizmo)`
- `EmitAnimationFrame(object animator)`
- `EmitLightingChanged(object light)`
- `EmitPostProcessChanged(object postProcess)`
- `EmitCustom(object source, object customData)`

### 5. `RenderableEventQueueSettings`
Configuration du système.

**Paramètres :**
- `MaxQueueSize` - Taille maximale de la queue (défaut: 1000)
- `DuplicateThreshold` - Délai pour considérer un doublon (défaut: 0.016s)
- `EnableDeduplication` - Activer la déduplication (défaut: true)
- `EnableGPUCache` - Activer le cache GPU (défaut: true)

### 6. `IRenderableEventSource`
Interface pour les objets qui peuvent émettre des événements.

### 7. `RenderableEventExtensions`
Extensions utilitaires pour `RenderableEvent`.

## Utilisation

### Exemple basique

```csharp
using Editor.Rendering;

// Émettre un événement
RenderableEventEmitter.EmitSceneObjectChanged(gameObject);
RenderableEventEmitter.EmitCameraMoved(cameraComponent);

// Dans votre widget de rendu
void Render()
{
    int eventCount = RenderableEventQueue.Count;
    
    if (eventCount == 0)
    {
        // Utiliser le cache
        if (_cacheManager.HasCachedFrame)
        {
            _cacheManager.BlitToSwapChain(SwapChain, Size);
            return;
        }
    }
    else if (eventCount == 1)
    {
        // Rendre et sauvegarder en cache
        var cacheTexture = _cacheManager.GetOrCreateCacheTexture(Size);
        RenderToTexture(cacheTexture);
        _cacheManager.MarkFrameCached();
    }
    else // eventCount > 1
    {
        // Rendre sans sauvegarder
        RenderScene();
    }
    
    // Vider la queue après le rendu
    RenderableEventQueue.Clear();
}
```

### Configuration

```csharp
var settings = new RenderableEventQueueSettings
{
    MaxQueueSize = 500,
    DuplicateThreshold = 0.033f, // ~2 frames à 60 FPS
    EnableDeduplication = true,
    EnableGPUCache = true
};

settings.Apply();
```

### Implémentation de l'interface

```csharp
public class MyGameObject : IRenderableEventSource
{
    public void EmitRenderableEvent(RenderableEvent evt)
    {
        RenderableEventQueue.Enqueue(evt);
    }
    
    public void EmitRenderableEvent(RenderableEvent.EventType type, object source = null)
    {
        RenderableEventQueue.Enqueue(type, source ?? this);
    }
    
    // Quand une propriété change
    public Vector3 Position
    {
        get => _position;
        set
        {
            if (_position == value) return;
            _position = value;
            EmitRenderableEvent(RenderableEvent.EventType.SceneObjectChanged);
        }
    }
}
```

## Intégration

Pour intégrer cette librairie dans `SceneRenderingWidget` :

1. Ajouter un `RenderCacheManager` au widget
2. Vérifier `RenderableEventQueue.Count` dans la méthode `Render()`
3. Implémenter la logique de cache selon la queue
4. Émettre des événements aux bons endroits (GameObject, Camera, etc.)

## Notes

- Le blit GPU vers SwapChain nécessite une API native (à implémenter)
- La déduplication évite les événements en double dans la même frame
- Le cache GPU est automatiquement géré (création/disposition)

