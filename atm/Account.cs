namespace atm;

public class Account(string accountNo)
{
    private int _balance;
    public string AccountNumber { get; } = accountNo;
    public int Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }
    public List<Transaction> Transactions { get; } = [];

    public void Deposit(int amount, TransactionTypeEnum type = TransactionTypeEnum.Insättning)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Du kan inte sätta in ett negativt belopp!");
        }
        Balance += amount;
        AddTransaction(amount, type);
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            throw new InvalidOperationException("Du har inte tillräckligt på kontot!");
        }
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Du kan inte ta ut ett negativt belopp!");
        }
        Balance -= amount;
        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }

    private void AddTransaction(int amount, TransactionTypeEnum transactionType)
    {
        var tran = new Transaction();
        tran.TransactionDate = DateTime.Now;
        tran.AccountNumber = AccountNumber;
        tran.TransactionValue = amount;
        tran.TransactionType = transactionType;
        Transactions.Add(tran);
    }

    public void DisplayTransactions()
    {
        foreach(var tran in Transactions)
        {
            Console.WriteLine(tran.GetTransactionInfo());
        }
    }

        public override string ToString()
    {
        return $"AccountNumber: {AccountNumber} Balance: {Balance} AccountType: {this.GetType()}";
    }
}
