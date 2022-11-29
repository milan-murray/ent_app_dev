// Milan Murray 8 Nov 2022
// C# Exercise 1

namespace Banking;

public enum TransactionType
{
    Deposit, Withdrawal
}

// an account transaction
public class AccountTransaction
{
    private TransactionType type;       // deposit/withdrawal
    private double amount;          // amount concerned

    // constructor
    public AccountTransaction(TransactionType type, double amount)
    {
        this.type = type;
        this.amount = amount;
    }

    // return human readable String
    public override String ToString()
    {
        return "type: " + type + " amount: " + amount;
    }
}

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNumIn) : base()
    {
        AccountNumber = accNumIn;
    }
    public override void MakeDeposit(decimal amountIn)
    {
        this.AccountBalance += amountIn;
    }

    public override void MakeWithdrawal(decimal amountIn)
    {
        this.AccountBalance -= amountIn;
    }

    public static void Main()
    {
        // ...
    }
}
