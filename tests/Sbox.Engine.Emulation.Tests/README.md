# Sbox.Engine.Emulation.Tests

Projet de tests unitaires pour la couche d'émulation NativeAOT de s&box.

## Structure

Ce projet contient les tests pour les modules d'émulation :
- `Common/` : Tests pour HandleManager et utilitaires communs
- `Camera/` : Tests pour CCameraRenderer
- `RenderAttributes/` : Tests pour CRenderAttributes
- `Material/` : Tests pour MaterialSystem
- `Audio/` : Tests pour AudioSystem
- etc.

## Utilisation

```bash
# Exécuter tous les tests
dotnet test

# Exécuter les tests d'un module spécifique
dotnet test --filter "FullyQualifiedName~Common"
```

## Notes

- Les tests sont organisés par module pour faciliter la maintenance
- Utiliser des mocks pour les dépendances entre modules
- Suivre le pattern de test existant dans le projet (MSTest)

