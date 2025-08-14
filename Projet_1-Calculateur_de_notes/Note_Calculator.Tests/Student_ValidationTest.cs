namespace Note_Calculator.Tests;

using Note_Calculator.Domain;
using Xunit;

//Pourquoi le TDD: l'objectif est de définir le besoin métier à travers un banc de test.
//Ce qui permet de recentrer le développement sur des composant qui sont essentiel et de
//ne pas produire plus de code que nécéssaire.
// -------------------------------------------------------------------------------------------------
// Le test (Rouge): Verifié si un étudiant à la moyen minimum pour validé son année scolaire (>= 10).
// -------------------------------------------------------------------------------------------------
public class Students_withAverage10OrAbove_ValidsYear
{
    [Fact]
    public void studentIsValidatingYear()
    {
        //Arrange:  On donne le contexte du test
        var student = new Student();
        student.AddNotes(10, 12, 14);

        //Act:      On execute le test
        bool isValid = student.IsPassingYear();

        //Assert:   On vérifie le résultat attendu
        Assert.True(isValid);
    }
}
