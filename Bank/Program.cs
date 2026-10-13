// Klasser, konstruktorer, properties, switch-case, try/catch, parse.ToLower:
using Bank;

try
{
    var account = new BankAccount(1001, "Leon", 1000);

    while (true)
    {
        Console.WriteLine("Välkommen, välj ett alternativ:");
        Console.WriteLine("Deposit: D");
        Console.WriteLine("Withdraw: W");
        Console.WriteLine("Exit: X");

        var inputKey = Console.ReadKey();
        Console.WriteLine();
        char key = char.ToLower(inputKey.KeyChar);

        switch (key)
        {
            case 'd':
                Console.Write("Ange belopp för insättning: ");
                string? depositInput = Console.ReadLine();
                if (decimal.TryParse(depositInput, out decimal deposit) && deposit > 0)
                {
                    account.Deposit(deposit);
                }
                else
                {
                    Console.WriteLine("Ogiltigt belopp.");
                }
                break;

            case 'w':
                Console.Write("Ange belopp för uttag: ");
                string? withdrawInput = Console.ReadLine();
                if (decimal.TryParse(withdrawInput, out decimal withdraw) && withdraw > 0)
                {
                    account.Withdraw(withdraw);
                }
                else
                {
                    Console.WriteLine("Ogiltigt belopp.");
                }
                break;

            case 'x':
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Något fel!");
                break;
        }

        Console.WriteLine($"Saldo: {account.Balance} kr");
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ett fel uppstod: {ex.Message}");
}
