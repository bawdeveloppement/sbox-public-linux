# FEATURES / MODES (VFX) — TODO pour implémentation complète

Ce mémo décrit ce qu’il reste à faire pour supporter réellement les blocs `FEATURES` et `MODES` dans les shaders VFX, au lieu de les supprimer avant compilation.

## État actuel
- Dans `ResourceCompilerSystem` nous strippons (`PreprocessShaderSource`) les blocs `FEATURES { ... }` et `MODES { ... }` pour permettre à `dxc` de compiler une variante « par défaut ».  
- Les blocs `COMMON/VS/PS/CS` doivent être déroulés (unwrapping) pour produire du HLSL standard que `dxc` accepte.  
- Les `.shader_c` générés contiennent donc uniquement une variante unique (pas de permutations), et la fidélité vis-à-vis du pipeline Source2 est limitée.

## Ce qu’il faudrait faire pour un support complet
1) **Parser FEATURES/MODES**  
   - Lire les blocs et construire une représentation des features et modes (statiques/dynamiques).  
   - Déterminer quelles combinaisons sont réellement nécessaires (éviter l’explosion combinatoire).

2) **Génération de permutations**  
   - Pour chaque combinaison choisie, injecter des `#define` appropriés avant la compilation HLSL.  
   - Dérouler `COMMON/VS/PS/CS` en HLSL pur, conserver les includes.

3) **Compilation multi-variantes**  
   - HLSL → SPIR-V (dxc) → GLSL (spirv-cross) pour chaque combinaison.  
   - Packager les variantes dans le conteneur `.shader_c` ou dans un conteneur multi-profils/profil+combo.

4) **Sélection au runtime**  
   - Matériaux : choisir la variante basée sur les features/modes demandés par le matériau/engine.  
   - Fallback explicite si une variante manque.

## Points ouverts / inconnus
- Spéc exact du format VFX (FEATURES/MODES) : mapping vers des `#define` et quelles combinaisons sont attendues par le moteur.  
- Format cible `.shader_c` pour stocker plusieurs variantes et plusieurs profils GLSL (GL330, GL120/130, ES300, …).  
- Gestion des includes manquants (ex : `math_general.fxc`), et des blocs FXC spécifiques (vr_common, etc.).

## Actions minimales si on veut avancer sans permutations
- Continuer à stripper FEATURES/MODES (comportement actuel).  
- Dérouler correctement COMMON/VS/PS/CS.  
- S’assurer que dxc/spirv-cross trouvent tous les includes (core + addons/base).

## Actions pour une implémentation complète (à planifier)
- Écrire un parseur FEATURES/MODES → générateur de combos (+ filtrage).  
- Émettre et stocker les variantes (multi-combos + multi-profils GLSL).  
- Adapter le runtime MaterialSystem pour sélectionner/charger la bonne variante.

