using System.Linq;

namespace Note_Calculator.Domain;
// --------------------------------------------------------------------------------------------------------
// Le métier : 
// Cette classe représente un étudiant et encapsule la logique métier liée à la validation de son année.
// --------------------------------------------------------------------------------------------------------
// Rappel du besoin : vérifier si un étudiant valide son année en fonction de la moyenne de ses notes.
// - Une moyenne >= 10 valide l’année.
// - Il reçoit une mention selon la moyenne obtenue :
//     ≥ 16 → Très bien
//     ≥ 14 → Bien
//     ≥ 12 → Assez bien
//     ≥ 10 → Passable
//     < 10 → Refusé
//
// Remarques :
// - Les notes sont stockées dans un champ privé en lecture seule (_notes).
// - Les mentions sont stockées avec leurs seuils dans une liste (_mentionRanges).
// - AddNotes permet l’injection contrôlée de notes via params.
// - IsValidating calcule la moyenne et vérifie si elle dépasse le seuil.
// - getsMention retourne la meilleure mention atteinte selon les seuils définis.
// - LINQ (Average) est utilisé pour simplifier le calcul de la moyenne.
public class Student
{
    private readonly List<int> _notes = new();
    private readonly List<(double noteReq, string Mention)> _mentionRanges = new()
    {
        (16, "Très bien"),
        (14, "Bien"),
        (12, "Assez bien"),
        (10, "Passable"),
    };
    private const string _mentionDenied = "Refusé";

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

    public string getsMention()
    {
        double average = _notes.Average();

        foreach(var (note, mention) in _mentionRanges)
        {
            if (average >= note)
                return mention;
        }

        return _mentionDenied;
    }
}
