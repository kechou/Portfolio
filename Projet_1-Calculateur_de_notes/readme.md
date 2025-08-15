# 🎓 Projet 1 – Calculateur de notes

## 🎯 Objectif pédagogique

Appliquer les principes du **Test Driven Development (TDD)** en C#, sans interface graphique ni base de données.

> 👉 Ce projet sert de base pour comprendre la logique métier, l'approche orientée tests, et les fondations d'une architecture propre.

---

## 🧠 Concepts travaillés

- ✅ TDD (Test Driven Development)
- ✅ Écriture de tests unitaires en premier
- ✅ Séparation des responsabilités (Clean Code)
- ✅ Conception d’un petit domaine métier pur
- ✅ Validation d’entrées et gestion des erreurs

---

## 🧱 Modèle métier

- **Student (Étudiant)** : gère la liste des notes, la validation et la mention
- *(Matière et Note prévues dans une future version plus riche)*

---

## ⚙️ Fonctionnalités

- Ajout de notes via le terminal
- Calcul de la **moyenne**
- Attribution d’une **mention** selon la moyenne
- Détermination si l’élève **valide son année**
- Interface **CLI simple et intuitive**

---

## 🔍 Règles de validation

### 📊 Calcul de la moyenne
> Moyenne = Somme des notes / Nombre de notes

### 🏅 Attribution des mentions

| Moyenne | Mention       |
|---------|----------------|
| ≥ 16    | Très bien      |
| ≥ 14    | Bien           |
| ≥ 12    | Assez bien     |
| ≥ 10    | Passable       |
| < 10    | Refusé         |

### ✅ Validation

Un étudiant est **validé** si sa moyenne est **≥ 10**.

---

## 💻 Stack technique

- **Langage** : C# (.NET 8)
- **Tests** : [xUnit](https://xunit.net/)
- **CLI** : Application console (terminal ASCII)
- **Structure du projet** :
  - `Note_Calculator.Domain` : logique métier (clean, testable, sans dépendances)
  - `Note_Calculator.Tests` : tests unitaires (xUnit)
  - `Note_Calculator.Cli` : interface terminal pour tester le calculateur

---

## 🚀 Utilisation

```bash
# Restauration et build
dotnet restore
dotnet build

# Lancer les tests
dotnet test

# Lancer l’application
cd Note_Calculator.Cli
dotnet run
