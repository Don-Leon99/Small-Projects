namespace Bank;
public class BankAccount
{
    public int AccountNumber { get; private set; }
    public string Owner { get; private set; } = "";
    public decimal Balance { get; private set; }

    public BankAccount(int accountNumber, string owner) : this(accountNumber, owner, 0){}
    public BankAccount(int accountNumber, string owner, decimal startBalance)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = startBalance;
    }

    public bool Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        else
        {
            Console.WriteLine("Need larger deposit.");
            return false;
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Not enough money");
            return false;
        }
    }
}
