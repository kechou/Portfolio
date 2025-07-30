namespace Note_Calculator.Domain;

//--------------------------------------------------------------------------------------------------------
// Le métier: Maintenant que l'on as posé les bases, on met-à-jour la classe Student afin de passer le test.
// Cette étape correspond à la phase du "Test Vert" dans le cycle TDD.
//--------------------------------------------------------------------------------------------------------
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

    public void SetNotes(params int[] notes) {
        _notes.AddRange(notes);
    }

    public bool Validate() {
        if (_notes.Count == 0)
            return false;

        int moyenne = 0;
        foreach (int note in _notes)
            moyenne += note;

        return ((double)moyenne / _notes.Count) >= 10; // Cast en double pour éviter l’arrondi entier lors de la division
    }
}
