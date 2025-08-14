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
    //Attribut ----------------------
    private readonly    List<int>                                   _notes = new();
    private readonly    Student_Exception                           _exceptionMsg = new();

    private readonly    List<(double noteReq, string Mention)>      MentionRanges = new()
    {
        (16, "Très bien"),
        (14, "Bien"),
        (12, "Assez bien"),
        (10, "Passable"),
    };
    


    //Méthodes ----------------------
    private void CheckNotes(int[]   notes)
    {
        if (notes is null || notes.Length == 0)
            throw new ArgumentException(_exceptionMsg.NotesEmpty);
        else
        {
            foreach(double note in notes)
            {
                if (note < 0 || note > 20)
                    throw new ArgumentException(_exceptionMsg.NotesOutOfRange);

            }
        }
    }

    public void AddNotes(params int[]   notes)
    {
        CheckNotes(notes);
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
        if (!_notes.Any() || _notes.Count == 0)
            return _exceptionMsg.MentionDenied;

        double average = _notes.Average();

        foreach(var (note, mention) in MentionRanges)
        {
            if (average >= note)
                return mention;
        }

        return _exceptionMsg.MentionDenied;
    }

    public IReadOnlyList<int> GetNotes()
    {
        return _notes.AsReadOnly();
    }
}
