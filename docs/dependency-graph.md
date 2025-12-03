# Graphe de Dépendances des Modules

Ce document décrit les dépendances entre les modules de la couche d'émulation NativeAOT.

## Règles

- **Consulter ce graphe** avant d'implémenter un nouveau module
- **Mettre à jour ce graphe** dès qu'une dépendance est identifiée
- **Respecter l'ordre d'implémentation** : Niveau 0 → Niveau 1 → Niveau 2 → ...

## Structure par Niveaux

### Niveau 0 - Core (aucune dépendance)

Modules fondamentaux qui ne dépendent d'aucun autre module d'émulation :

- **Common** (`Common/HandleManager.cs`)
  - Gestionnaire centralisé de handles
  - Aucune dépendance interne
  - Dépendances externes : `System.Collections.Concurrent`

- **Platform** (`Platform/PlatformFunctions.cs`)
  - Fonctions de plateforme (GLFW, OpenGL, fenêtres)
  - Aucune dépendance interne
  - Dépendances externes : `Silk.NET.GLFW`, `Silk.NET.OpenGL`

### Niveau 1 - Base Systems

Modules qui dépendent uniquement du Niveau 0 :

- **FileSystem** (`FileSystem/FileSystemFunctions.cs`)
  - Système de fichiers
  - Dépend de : `Platform`
  - Dépendances externes : `Sandbox.Filesystem`

- **Texture** (`Texture/TextureSystem.cs`)
  - Gestion des textures
  - Dépend de : `Platform`, `Common`
  - Dépendances externes : `Silk.NET.OpenGL`

### Niveau 2 - Rendering Base

Modules de base pour le rendu :

- **RenderAttributes** (`RenderAttributes/RenderAttributes.cs`)
  - Attributs de rendu (CRenderAttributes)
  - Dépend de : `Common`
  - Dépendances externes : Aucune

- **Material** (`Material/MaterialSystem.cs`)
  - Système de matériaux (MaterialSystem2, IMaterial2)
  - Dépend de : `RenderAttributes`, `Texture`, `Common`
  - Dépendances externes : `Sandbox.Engine`

### Niveau 3 - Rendering Advanced

Modules avancés pour le rendu :

- **RenderTools** (`RenderTools/RenderTools.cs`)
  - Outils de rendu (RenderTools_SetRenderState, RenderTools_Draw)
  - Dépend de : `RenderAttributes`, `Material`, `Platform`
  - Dépendances externes : `Silk.NET.OpenGL`

- **Scene** (`Scene/*.cs`)
  - Objets de scène (CSceneObject, CDecalSceneObject, etc.)
  - Dépend de : `RenderAttributes`, `Material`, `Texture`, `RenderTools`
  - Dépendances externes : `Sandbox.Engine`

### Niveau 4 - High Level

Modules de haut niveau :

- **Camera** (`Camera/CameraRenderer.cs`)
  - Rendu de caméra (CCameraRenderer)
  - Dépend de : `Scene`, `RenderTools`, `Material`
  - Dépendances externes : `Sandbox.Engine`

- **Model** (`Model/*.cs`)
  - Modèles 3D (CModel, CRenderMesh)
  - Dépend de : `Material`, `Texture`
  - Dépendances externes : `Sandbox.Engine`

### Modules Indépendants (peuvent être parallélisés)

Ces modules peuvent être implémentés en parallèle car ils n'ont pas de dépendances entre eux :

- **Audio** (`Audio/*.cs`)
  - Système audio (DSP, AudioMixBuffer, AudioMixer, etc.)
  - Dépend de : `Common`
  - Dépendances externes : `Silk.NET.OpenAL`

- **Yoga** (`Yoga/YogaFunctions.cs`)
  - Layout engine (Yoga)
  - Dépend de : `Common`
  - Dépendances externes : `libyogacore.so` (P/Invoke)

- **Physics** (`Physics/*.cs`)
  - Physique (déjà partiellement implémenté)
  - Dépend de : `Common`
  - Dépendances externes : `BepuPhysics`

- **Input** (`Input/*.cs`)
  - Système d'entrée (InputService, InputSystem)
  - Dépend de : `Platform`
  - Dépendances externes : `Silk.NET.Input`

- **Frustum** (`Frustum/Frustum.cs`)
  - Frustum de caméra (CFrustum)
  - Dépend de : Aucune (module indépendant)
  - Dépendances externes : Aucune

- **Animation** (`Animation/*.cs`)
  - Animation (CAttachment, CnmtnGrpBldr)
  - Dépend de : `Common`
  - Dépendances externes : `Sandbox.Engine`

- **VFX** (`VFX/*.cs`)
  - Effets visuels (CVfx, CVfxCombinator, etc.)
  - Dépend de : `Common`
  - Dépendances externes : `Sandbox.Engine`

- **Video** (`Video/*.cs`)
  - Lecture/enregistrement vidéo (CVideoPlayer, CVideoRecorder)
  - Dépend de : `Common`
  - Dépendances externes : À déterminer

## Ordre d'Implémentation Recommandé

### Phase 0 - Préparation
1. ✅ Common (HandleManager) - **TERMINÉ**
2. Platform (si nécessaire pour les tests)

### Phase 1 - Refactorisation (Prioritaire)
1. **Camera** (CCameraRenderer) - **PRIORITAIRE** (bug actuel)
2. RenderAttributes
3. Material
4. RenderTools
5. Scene (progressivement)

### Phase 2+ - Implémentation des fonctions manquantes
- Implémenter les modules indépendants en parallèle (Audio, Yoga, Physics, Input, etc.)
- Implémenter les modules de haut niveau (Model, etc.)
- Organiser et implémenter les fonctions "Other"

## Notes

- **Dépendances circulaires** : À éviter absolument. Si une dépendance circulaire est identifiée, réorganiser les modules.
- **Dépendances externes** : Les dépendances vers `Sandbox.Engine`, `Silk.NET.*`, etc. sont acceptables car ce sont des bibliothèques externes.
- **Mise à jour** : Ce graphe doit être mis à jour à chaque fois qu'une nouvelle dépendance est identifiée.

## Légende

- **Niveau X** : Ordre d'implémentation (0 = premier, 1 = deuxième, etc.)
- **Dépend de** : Modules d'émulation requis
- **Dépendances externes** : Bibliothèques externes requises

