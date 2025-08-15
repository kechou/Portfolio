namespace Note_Calculator.Tests;

using Xunit;
using Note_Calculator.Domain;

public class Students_withSpecificAverage_GetSpecificMention
{
    [Theory]
    [InlineData(new double[] { 8, 9, 10 }, "Refusé")]
    [InlineData(new double[] { 10, 10, 11 }, "Passable")]
    [InlineData(new double[] { 12, 13, 14 }, "Assez bien")]
    [InlineData(new double[] { 14, 15, 16 }, "Bien")]
    [InlineData(new double[] { 17, 18, 19 }, "Très bien")]
    public void studentIsValidatingYear(double[] notes, string expectedMention)
    {
        //Arrange:  On donne le contexte du test
        var student = new Student();
        student.AddNotes(notes);

        //Act:      On execute le test
        string mention = student.GetMention();

        //Assert:   On vérifie le résultat attendu
        Assert.Equal(expectedMention, mention);
    }
}