using Api.Extensions;
using Api.Model.States;

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

    public int CalculateArmyStrength()
    {
        return Board.ToEnumerable<Card>()
            .Sum(x => x.Strength);
    }

    public void PlayCard(Card card, int row, int column)
    {
        Board[row, column] = card;
        card.Row = row;
        card.Column = column;
    }
}