namespace atm;

public class Transaction
{
    public string AccountNumber { get; set;} = "";
    public DateTime TransactionDate { get; set; }
    public int TransactionValue { get; set; }
    public TransactionTypeEnum TransactionType { get; set; }
    public string GetTransactionInfo()
    {
        return $"Datum: {TransactionDate}, Konto: {AccountNumber}, Belopp: {TransactionValue}, Typ: {TransactionType}";
    }
}
