# Projet 1 – Calculateur de notes

## 🎯 Objectif pédagogique

Apprendre le **Test Driven Development (TDD)** en C# avec xUnit, sans base de données ni UI.

## 🧠 Concepts travaillés

- TDD (Test Driven Development)
- Écriture de tests en premier
- Conception d’un petit domaine métier

## 🧱 Domaines / Classes

- Étudiant
- Matière
- Note

## ⚙️ Fonctionnalités

- Calcul de moyenne
- Attribution d’une mention
- Détermination de la validation

## 🔍 Comportement attendu

Le calculateur de notes fonctionne selon les règles suivantes :

1. **Calcul de la moyenne**
   - La moyenne est la somme des notes divisée par leur nombre

2. **Attribution de la mention** (en fonction de la moyenne)
   - ≥ 16 : Très bien
   - ≥ 14 : Bien
   - ≥ 12 : Assez bien
   - ≥ 10 : Passable
   - < 10 : Insuffisant

3. **Validation**
   - L’élève est validé si la moyenne ≥ 10


## 🧪 Stack technique

- .NET 8
- xUnit
- Structure :
  - `NoteCalculator.Domain` : logique métier (sans dépendances)
  - `NoteCalculator.Tests` : tests unitaires avec xUnit
