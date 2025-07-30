namespace Note_Calculator.Domain;

//On défini le squelette de notre objet métier.
//non seulement cela pose la base de notre architecture,
//mais cela est aussi le minimum pour faire fonctionné le test.
//
//Un aspect TRES important est d'uniquement implémenter le MINIMUM possible pour rendre le test fonctionnel.
//Comme cela on ne perd pas de temps à développer les feature clef et on gagne du temps et des ressources.
//--------------------------------------------------------------------------------------------------------
// Le métier: La classe Student dans sa définition la plus basique pour notre besoin actuel
// (ie. faire fonctionner le test -> on s'attend à ce qu'il nous renvoi une erreur).
//--------------------------------------------------------------------------------------------------------
public class Student
{
    private readonly List<int> _notes = new();

    public void SetNotes(params int[] notes) {
        _notes.AddRange(notes);
    }

    public bool Validate() {
        //pas besoin de logique interne pour le moment on veux juste rendre le test fonctionnel
        return false;
    }
}
