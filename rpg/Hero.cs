namespace rpg;

public class Hero
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; private set; } = 1;
    public int MaxHealth { get; private set; } = 100;
    public int CurrentHealth { get; private set; } = 100;
    public int MaxMana { get; private set; } = 50;
    public int CurrentMana { get; private set; } = 50;
    public int Strength { get; private set; } = 10;
    public int Experience { get; private set; } = 0;
    public int Gold { get; private set; } = 0;

    public bool IsAlive => CurrentHealth > 0;

    public List<string> Inventory { get; } = new List<string>();
    public List<Skill> Skills { get; } = new List<Skill>();

    public Hero(string name, string heroClass)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Hero needs a name");
        }
        if (string.IsNullOrWhiteSpace(heroClass))
        {
            throw new ArgumentException("Hero needs a class");
        }
        Name = name;
        Class = heroClass;
    }
    public void LevelUp()
    {
        Level++;
        MaxHealth += 20;
        CurrentHealth = MaxHealth;
        MaxMana += 10;
        CurrentMana = MaxMana;
        Strength += 5;
        Experience = 0;
        Gold += 100;
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if(CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }
    public void learnSkill(Skill skill)
    {
        if(!Skills.Contains(newSkill))
        {
            Skills.Add(newSkill);
            Console.WriteLine($"{Name} have learned a new skill: {newSkill.Name}!");
        }
    }
    public void UseSkill(Skill skill, Hero target)
    {
        if (!Skills.Contains(skill))
        {
            Console.WriteLine($"{Name} does not know the skill {skill.Name}.");
            return;
        }
        if(CurrentMana < skill.ManaCost)
        {
            Console.WriteLine($"{Name} does not have enough mana to use {skill.Name}.");
            return;
        }

        CurrentMana -= Skill.ManaCost;

        target.TakeDamage(skill.Power);
        Console.WriteLine($"{Name} använde {skill.Name} mot {target.Name} och gjorde {skill.Power} skada!");
    }
    
    public void Heal (int amount)
    {
        CurrentHealth += amount;
        if(CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
}
