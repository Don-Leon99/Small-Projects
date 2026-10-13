namespace rpg;

public class Skill
{
    public String Name { get; private set; }
    public String Description { get; private set; }
    public int ManaCost { get; private set; }
    public int Power { get; private set; }
    public double StrengthScaling { get; private set; }
    public int LevelRequirement { get; private set; }

    public Skill(
        string name,
        string description,
        int power,
        int manaCost,
        double strengthScaling,
        int levelRequirement)
    {
        Name = name;
        Description = description;
        Power = power;
        ManaCost = manaCost;
        StrengthScaling = strengthScaling;
        LevelRequirement = levelRequirement;
    }

    public static Skill Fireball => new Skill(
        name: "Fireball",
        description: "A powerful fire spell that deals damage to a single target.",
        power: 30,
        manaCost: 20,
        levelRequirement: 1
    );
    public static Skill Heal => new Skill(
        "Heal",
        "Återställer hälsa.",
        power: 25,
        manaCost: 10,
        levelRequirement: 1);

    public static Skill Slash => new Skill(
        "Slash",
        "Ett kraftfullt svärdhugg.",
        power: 18,
        manaCost: 0,
        levelRequirement: 1);

    public int CalculateTotalPower(int heroStrength)
    {
        return Power + (int)(heroStrength * StrengthScaling);
    }
}
