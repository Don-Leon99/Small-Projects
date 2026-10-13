namespace rpg;

public class Enemy
{
    public string Name { get; private set; }
    public int Level { get; private set; } = 1;
    public int MaxHealth { get; private set; } = 100;
    public int CurrentHealth { get; private set; } = 100;
    public int Strength { get; private set; } = 10;

    public bool IsAlive => CurrentHealth > 0;

    public Enemy(string name,
    int level,
    int baseHealth,
    int baseStrength,
    int healthPerLevel,
    int strengthPerLevel)
    {
        Name = name;
        Level = level;
        MaxHealth = baseHealth + (level - 1) * healthPerLevel;
        CurrentHealth = MaxHealth;
        Strength = baseStrength + (level - 1) * strengthPerLevel;
    }
    public static Enemy CreateWarrior(int level)
    {
        return new Enemy("Warrior Enemy", level, baseHealth: 100, baseStrength: 10, healthPerLevel: 20, strengthPerLevel: 5);
    }
    public static Enemy CreateRanger(int level)
    {
        return new Enemy("Ranger Enemy", level, baseHealth: 60, baseStrength: 12, healthPerLevel: 10, strengthPerLevel: 4);
    }
    public static Enemy CreateMage(int level)
    {
       return new Enemy("Mage Enemy", level, baseHealth: 50, baseStrength: 15, healthPerLevel: 8, strengthPerLevel: 6);
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }
}
