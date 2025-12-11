Décoder le format .shader Source2 : parsing du DSL, gestion des permutations/options, includes, macros, variants (smoke, debug, platform).
Choisir la chaîne de compilation : glslang pour générer du SPIR-V, éventuellement spirv-opt pour optimiser. Il faut supporter tous les stages (vs/ps/gs/cs) utilisés par Sandbox.
Réflexion et mapping : extraire inputs/outputs, UBO/SSBO, samplers, push constants, layouts. Les mapper vers notre backend OpenGL (binding points, texture units, UBO indices) et conserver un schéma stable.
Format de sortie : produire un blob (SPIR-V ou GLSL final) + métadonnées (réflexion, permutations, hashes) dans un format consommable par le runtime Sandbox. Soit on reproduit le format VFX/VCS attendu, soit on définit un format émulé et on adapte le loader.
Compatibilité runtime : adapter IResourceCompilerSystem.GenerateResourceBytes et le chargement des shaders pour accepter notre nouveau format. S’assurer que le pipeline de ressources (montage de fichiers, caches) suit.
Gestion des permutations : compilation combinatoire coûteuse. Nécessite caching, hashes, invalidation et parallélisation pour rester viable.
Validation & erreurs : surfacer des messages d’erreur clairs (fichiers/ligne), timeouts, et un mode strict pour CI.
Ciblage GPU : pour OpenGL, décider si on garde SPIR-V puis on transpile (spirv-cross) ou si on émet directement du GLSL ciblé. Gérer les profils (GL 4.x), extensions requises et fallback sur plateformes (ex. Raspberry Pi → GLES?).
Layouts et ABI : alignement std140/std430, ordonnancement des bindings, noms stables, pour éviter les dérives entre compilation et usage.
Intégration build/outillage : ajouter les deps (glslang/spirv-tools/spirv-cross) en natif ou via bindings, gérer leur distribution (Linux cible), et s’assurer que NativeAOT trouve les libs.
Performances : éviter d’allonger les temps de build/runtime. Caching sur disque + en mémoire, et limiter la recompilation à l’incrémental.
Tests : corpus de shaders existants, tests de réflexion (bindings, types, tailles), tests de rendu basiques pour valider que les layouts et uniformes correspondent.
