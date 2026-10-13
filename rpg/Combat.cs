using System.Security.Cryptography.X509Certificates;

namespace rpg;

public class Combat
{
    public void StartBattle(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"A wild {enemy.Name} appears!");

        while (Hero.IsAlive && enemy.IsAlive)
        {
            ShowStatus(hero, enemy);

            PlayerTurn(hero, enemy);
            if (!enemy.IsAlive)
            {
                Console.WriteLine($"{hero.Name} defeated {enemy.Name}!");
                break;
            }
            enemyTurn(hero, enemy){
                if (!hero.IsAlive)
                {
                    Console.WriteLine($"{hero.Name} is defeated by {enemy.name}... Game Over!");
                    break;
                }
            }
        }
    }
    private void ShowStatus(Hero hero, Enemy enemy)
    {

    }
    private void PlayerTurn(Hero hero, Enemy enemy)
    {

    }
    private void EnemyTurn(Hero hero, Enemy enemy)
    {

    }
    private void UseSkillMenu(Hero hero, Enemy enemy)
    {
        if (hero.Skills.Count == 0)
        {
            Console.WriteLine("You don't have any skills!");
            //enemy.TakeDamage(hero.Strength); 
            return;
        }
        Console.WriteLine("Choose skill:");
        for (int i = 0; i < hero.Skills.Count; i++)
        {
            Skill s = hero.Skills[i];
            Console.WriteLine($"{i + 1}. {s.Name} (Mana: {s.ManaCost}, Power: {s.CalculateTotalPower(hero.Strength)})");
        }
        Console.Write("Choose number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= hero.Skills.Count)
        {
            Skill selectedSkill = hero.Skills[choice - 1];
            Hero target = enemy;
            hero.UseSkill(selectedSkill, target);
        }
        else
        {
            Console.WriteLine("Ogiltigt färdighetsval!");
        }
    }

}

