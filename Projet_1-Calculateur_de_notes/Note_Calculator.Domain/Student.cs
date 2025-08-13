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
public class Student
{
    private readonly List<int> _notes = new();
    private readonly List<(double noteReq, string Mention)> MentionRanges = new()
    {
        (16, "Très bien"),
        (14, "Bien"),
        (12, "Assez bien"),
        (10, "Passable"),
    };
    private const string MentionDenied = "Refusé";

    public void AddNotes(params int[] notes)
    {
        _notes.AddRange(notes);
    }

    public bool IsValidating()
    {
        if (_notes.Count == 0)
            return false;

        return (_notes.Average()) >= 10;
    }

    public string GetsMention()
    {
        double average = _notes.Average();

        if (!_notes.Any())
            return MentionDenied;

        foreach(var (note, mention) in MentionRanges)
        {
            if (average >= note)
                return mention;
        }

        return MentionDenied;
    }
}
