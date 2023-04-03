using Api.Model;
using NUnit.Framework;

namespace TestApi.Model;

public class PlayerTester
{
    [Test]
    public void Playerboard()
    {
        // Arrange
        var playerboard = new Player();

        // Act
        playerboard.Board[0, 3] = new Card("Dwarf", 3);

        // Assert

    }

    [Test]
    public void Playerboard2()
    {
        // Arrange
        var playerboard = new Player();

        // Act
        playerboard.Board[0, 3] = new Card("Dwarf", 3);

        // Assert
        Assert.AreEqual(3, playerboard.CalculateScore());
    }
}