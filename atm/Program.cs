namespace atm;

class Program
{
    static void Main()
    {
        var balance = 0;
        int deposit = 0;

        while(deposit < 1)
        {
        Console.WriteLine("Hej, hur mycket pengar vill du sätta in?");
        string? depositInput = Console.ReadLine();

        if(int.TryParse(depositInput, out deposit) && deposit >= 1)
            {
                balance += deposit;
                Console.WriteLine($"Din balans är nu {balance}kr.");
            }
            else
            {
                Console.WriteLine("ERROR: Ange giltigt värde!");
            }
        }

            Console.WriteLine("Vill du ta ut pengar? JA/NEJ");
            string? YesNo = Console.ReadLine()?.ToLower();

                if (YesNo == "ja")
                {
                    int withdraw = 0;
                    bool validWithdraw = true;
                    
                    while (validWithdraw)
            {
                Console.WriteLine("Hur mycket vill du ta ut?");
                string? withdrawInput = Console.ReadLine();

                if (int.TryParse(withdrawInput, out withdraw) && withdraw > 0)
                {
                    if (withdraw <= balance)
                    {
                        balance = deposit - withdraw;
                        Console.WriteLine($"Ditt nya saldo är {balance}kr.");
                        Console.WriteLine("Hejdå!");
                        validWithdraw = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: du kan inte ta ut mer än vad du har på kontot.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Var snäll att ange ett giltigt belopp i siffror!");
                }
            }

        }
        else if (YesNo == "nej")
        {
            Console.WriteLine("OK! Hejdå!");
        }
        else
        {
            Console.WriteLine("ERROR: Ange endast 'ja' eller 'nej'");
            
        }
    }
}
