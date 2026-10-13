namespace atm;

public class SavingsAccount(string accountNo)
    : Account(accountNo)
{
    private const double INTEREST_RATE = 0.05;

    public void ApplyInterest()
    {
        int interestAmount = Convert.ToInt32(base.Balance * INTEREST_RATE);
        if(interestAmount > 0)
        {
            Deposit(interestAmount, TransactionTypeEnum.Ränta);
        }
    }

    public override string ToString()
    {
        return $"AccountNumber: {AccountNumber} Balance: {Balance} InterestRate: {INTEREST_RATE} AccountType: {this.GetType()}";
    }
}