using Api.Model.Abilities;

namespace Api.Model;

public class Card
{
    public Card(string name, int victoryPoints)
    {
        Name = name;
        VictoryPoints = victoryPoints;
    }

    public string Name { get; }
    public int VictoryPoints { get; set; }
    public int Health { get; set; }
    public int Armor { get; set; }
    public IAbility[] Abilities { get; set; }
}