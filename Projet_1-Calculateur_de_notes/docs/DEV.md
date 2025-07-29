# 📘 Guide de développement – NoteCalculator

Ce fichier résume les commandes essentielles et la méthode de travail utilisée dans ce projet pour appliquer le TDD en C# avec .NET et xUnit.

---

## ⚙️ Structure du projet

- `NoteCalculator.Domain` : bibliothèque de classes contenant la logique métier
- `NoteCalculator.Tests` : projet de test unitaire basé sur xUnit

---

## 🚀 Commandes de création (rappel)

```bash
# 1. Créer la solution
dotnet new sln -n NoteCalculator

# 2. Créer la lib métier
dotnet new classlib -n NoteCalculator.Domain

# 3. Créer le projet de test xUnit
dotnet new xunit -n NoteCalculator.Tests

# 4. Ajouter les projets à la solution
dotnet sln add NoteCalculator.Domain/NoteCalculator.Domain.csproj
dotnet sln add NoteCalculator.Tests/NoteCalculator.Tests.csproj

# 5. Référencer le projet métier depuis le projet de test
dotnet add NoteCalculator.Tests reference NoteCalculator.Domain
```

---

## 🧪 Cycle TDD

1. ✍️ Écrire un test unitaire dans `NoteCalculator.Tests`  
   > Même si le code testé n'existe pas encore !

2. 🔨 Implémenter le code minimal dans `NoteCalculator.Domain`  
   > Juste assez pour faire passer le test

3. ♻️ Refactoriser  
   > Simplifier, renommer, structurer… sans casser le test

4. 🔁 Recommencer pour chaque nouvelle règle métier

---

## ✅ Astuce pour exécuter les tests

```bash
dotnet test
```

Cela exécutera tous les tests du projet xUnit.

---

## 📌 Bonnes pratiques

- Les tests dépendent du domaine, **pas l’inverse**
- Garder `Domain` propre : pas de dépendances, pas de code de test
- Un test = un scénario métier clair

---

Ce fichier est là pour t'aider à rester cadré dans ta pratique du TDD.
