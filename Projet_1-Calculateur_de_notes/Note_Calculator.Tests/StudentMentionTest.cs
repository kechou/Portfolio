namespace Note_Calculator.Tests;

using Xunit;
using Note_Calculator.Domain;

public class Students_withSpecificAverage_GetSpecificMention
{
    [Theory]
    [InlineData(new int[] { 8, 9, 10 }, "Refusé")]
    [InlineData(new int[] { 10, 10, 11 }, "Passable")]
    [InlineData(new int[] { 12, 13, 14 }, "Assez bien")]
    [InlineData(new int[] { 14, 15, 16 }, "Bien")]
    [InlineData(new int[] { 17, 18, 19 }, "Très bien")]
    public void studentIsValidatingYear(int[] notes, string expectedMention)
    {
        //Arrange:  On donne le contexte du test
        var student = new Student();
        student.AddNotes(notes);

        //Act:      On execute le test
        var mention = student.getsMention();

        //Assert:   On vérifie le résultat attendu
        Assert.Equal(expectedMention, mention);
    }
}