using System.Linq;

namespace Note_Calculator.Domain;

// --------------------------------------------------------------------------------------------------------
// Le métier : Refactorisation de la classe Student. On conserve le comportement validé par le test vert,
// mais on améliore la lisibilité, les noms, et on utilise des méthodes plus expressives (Average, AddNotes).
// Cela conclut la boucle TDD : Red ➜ Green ➜ Refactor.
// --------------------------------------------------------------------------------------------------------
// Rappel du besoin : vérifier si un étudiant valide son année en fonction de la moyenne de ses notes.
// - Une moyenne >= 10 valide l’année.
// - L’implémentation suit le principe du TDD : uniquement le code nécessaire pour passer le test vert.
//
// Remarques :
// - Les notes sont stockées en interne via un champ privé en lecture seule (_notes).
// - SetNotes permet l’injection contrôlée des notes via params.
// - Validate calcule la moyenne et retourne un booléen selon le seuil requis.
public class Student
{
    private readonly List<int> _notes = new();

    public void AddNotes(params int[] notes)
    {
        _notes.AddRange(notes);
    }

    public bool IsValidating()
    {
        if (_notes.Count == 0)
            return false;

        return (_notes.Average()) >= 10; //Simplification du calcul du résultat grace à l'appel d'une méthode LINQ.
    }
}
