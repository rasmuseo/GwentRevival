using Api.Extensions;

namespace Api.Model;

public class Player
{
    public Player()
    {
        Board = new Card[3,9];
    }

    public string? Name { get; set; }
    public Card[]? Hand { get; set; }
    public Card[,] Board { get; set; }

    public int CalculateScore()
    {
        return Board.ToEnumerable<Card>()
            .Sum(x => x.VictoryPoints);
    }
}