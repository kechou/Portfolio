namespace Note_Calculator.Tests;

using Xunit;
using Note_Calculator.Domain;

public class Student_CriticalCases_Tests
{
    [Fact]
    public void Students_withoutAnyNotes()
    {
        //Arrange
        var student = new Student();

        //Act
        bool isValid = student.IsValidating();
        string mention = student.GetsMention();
    
        //Assert
        Assert.False(isValid);
        Assert.Equal("Refusé", mention);
    }

    [Fact]
    public void Students_withAverageEquals_ExactlyTen_ShouldPass()
    {
        //Arrange
        var student = new Student();
        student.AddNotes(10, 10, 10);

        //Act
        bool isValid = student.IsValidating();
    
        //Assert
        Assert.True(isValid);
    }

    [Fact]
    public void Students_withOnlyOneNote()
    {
        //Arrange
        var student = new Student();
        student.AddNotes(10);

        //Act
        bool isValid = student.IsValidating();
        string mention = student.GetsMention();
    
        //Assert
        Assert.True(isValid);
        Assert.Equal("Passable", mention);
    }

    [Fact]
    public void Students_withNotesValueOutsideScope_AreFilteredOut()
    {
        //Arrange
        var student = new Student();

        //Assert & Act
        var exception = Assert.Throws<ArgumentException>(() => student.AddNotes(-12, 0, 45));
        Assert.Equal("Une des notes est hors de la plage autorisée (0 à 20).", exception.Message);
    }
}