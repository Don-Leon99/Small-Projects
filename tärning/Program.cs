// Hit Dice!
Console.WriteLine("Hello! Time to hit a dice!");

bool keepPlaying = true;

while (keepPlaying)
{
    Console.WriteLine("Choose how many dices you want to roll!");
    var amount = Console.ReadLine();

    if (int.TryParse(amount, out int amountOfRolls))
    {

        Console.WriteLine($"You got {amountOfRolls} amount of dices and they hit:");
        RollDice(amountOfRolls);

        while (true)
        {
            Console.WriteLine("Do you want to roll again? Y/N");
            var input = Console.ReadLine();
            var key = input?.ToLower();

            if (key == "y")
            {
                break;
            }
            if (key == "n")
            {
                Console.WriteLine("Fuck off då!");
                keepPlaying = false;
                break;
            }
            else
            {
                Console.WriteLine("Please choose Y or N.");
            }
        }
    }
    else
    {
        Console.WriteLine("Ops! Input valid number!");
    }
}

static void RollDice(int amount)
{
    Random random = new Random();

    for (int i = 0; i < amount; i++)
    {
        int dice = random.Next(1, 7);
        Console.WriteLine($"Roll {i + 1}: {dice}");
    }
}