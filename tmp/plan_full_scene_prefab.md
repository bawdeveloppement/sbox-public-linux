# Plan – Loader scènes/prefabs (.scene / .prefab)

## Objectif
Implémenter un loader emulation NativeAOT pour les scènes et prefabs Source2/S&box, capable de charger au moins un chemin minimal (.scene/.prefab texte ou compilé) pour instancier caméra(s), entités et modèles de test, afin que `Graphics.OnLayer` émette enfin des draws via RenderTools.

## Périmètre
- Formats visés : `.scene` et `.prefab` présents sous `game/addons/**/Assets/scenes/*.scene` (texte KV3) et, à terme, leurs versions compilées `.scene_c` / `.prefab_c`.
- Chargement managé (C#) dans l’émulation ; pas de dépendance native externe.
- Cible minimale : charger une scène simple (ex: `templates/addon.minimal/Assets/scenes/minimal.scene`) avec au moins une caméra et un modèle statique.

## Stratégie
1) **Reconnaissance format** :
   - Inspecter plusieurs `.scene` (texte KV3) et `.prefab` pour identifier la structure (Root, Entities, Components, Model, Transform, Camera, Light).
   - Vérifier présence/absence des versions compilées `_c`; décider si on lit d’abord les sources texte (plus simples) puis on ajoutera le support binaire.

2) **Parser KV3 texte minimal** :
   - Utiliser un parseur léger (Regex/Tokenizer simple) ou réutiliser une infra existante si présente dans le repo. Objectif : extraire au moins :
     - Entities/Objects list, leurs components (Transform, ModelComponent, CameraComponent), leurs références de ressources (vmdl, vmat), leurs props de base (position, rotation, scale).

3) **Représentation et instanciation** :
   - Définir un DTO `ScenePrefabData` (entities, components, resources).
   - Au chargement :
     - Créer une `SceneWorld`/`SceneView` si nécessaire.
     - Pour chaque caméra trouvée : créer un `ManagedCamera` avec un ID stable (ex: 1) et pousser ses transforms/FOV.
     - Pour chaque modèle : demander `ModelSystem.CreateModelFromResourceHelper`, créer un `SceneObject`/handle, appliquer transform.

4) **Intégration pipeline** :
   - Point d’entrée : nouveau module `ScenePrefabLoader` (ou extension de `SceneSystem`) avec API `LoadScene(string path)` / `LoadPrefab(string path)`.
   - Hook initialisation : charger une scène par défaut (ex: minimal.scene) quand `EngineExports` init ou au premier frame si aucune scène active.
   - Mettre à jour `EmulatedSceneView` pour utiliser la caméra chargée (ManagedCameraId) et attacher la layer/output existante.

5) **Fallback & validation** :
   - Si parsing échoue, créer une scène de secours : une caméra à l’origine + un cube (vmdl dev/box) posé devant, pour forcer des draws.
   - Logs ciblés : succès/échec parsing, nb d’entités, caméra utilisée, modèles instanciés.

6) **Évolutions** (phase 2) :
   - Support des versions compilées `.scene_c` / `.prefab_c` (binaire) en reverse-engineering : identifier l’en-tête, tables de chaînes, blocs ressources.
   - Support des lights basiques (pour test) et des components additionnels.

## Étapes concrètes
- [ ] Lister/échantillonner 3-4 `.scene` et `.prefab` (dont minimal.scene) pour confirmer le schema KV3.
- [ ] Écrire un parseur KV3 simplifié pour les champs nécessaires (Transform, Camera, Model path).
- [ ] Créer `ScenePrefabLoader` avec DTO + mapping vers SceneSystem/CameraRenderer/ModelSystem/HandleManager.
- [ ] Charger `minimal.scene` au boot si aucune scène active ; créer ManagedCamera (id=1) et un objet modèle.
- [ ] Ajouter fallback cube/caméra si parsing échoue.
- [ ] Vérifier que `Graphics.OnLayer` reçoit bien une caméra et que RenderTools loggue un draw.
- [ ] (Phase 2) Prototyper lecture binaire `.scene_c` / `.prefab_c`.

## Risques
- Complexité du format compilé (`_c`) : nécessite reverse-engineering supplémentaire.
- Parseur KV3 trop naïf : prévoir des garde-fous/logs et un fallback solide.
- Références croisées ressources (materials, models) non résolues si les systèmes associés restent partiels.

## Livrables
- `ScenePrefabLoader` (C#) + tests manuels (chargement minimal.scene) + logs détaillés.
- Intégration dans l’initialisation emulation pour avoir une scène/caméra par défaut.
- Fallback visuel (cube) garantissant un rendu même en cas d’échec parsing.
