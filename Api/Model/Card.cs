using Api.Model.Abilities;
using Api.Model.States;

namespace Api.Model;

public class Card
{
    public Card(string name, int strength)
    {
        Name = name;
        Strength = strength;
    }

    public string Name { get; }
    public int Strength { get; set; }
    public int Armor { get; set; }
    public IAbility[] Abilities { get; set; }
    public int? Row { get; set; }
    public int? Column { get; set; }

    public Row GetRow()
    {
        switch (Row)
        {
            case 1: return States.Row.Melee;
            case 2: return States.Row.Ranged;
            case 3: return States.Row.Siege;
        }
    }
}