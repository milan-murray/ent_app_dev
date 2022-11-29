// Milan Murray 8 Nov 2022
// C# Exercise 1

namespace Banking;

public abstract class BankAccount
{
    const decimal StartingBalance = 0.0M;
    string accountNumber = "";
    decimal accountBalance;

    public string AccountNumber
    {
        // Init property
        init
        {  
            if (value != null)
            {
                accountNumber = value;
            }
        }

        // Read property
        get
        {
            return accountNumber;
        }
    }

    public decimal AccountBalance
    {
        // Write property
        set
        {
            try
            {
                accountBalance = value;
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        // Read property
        get
        {
            return accountBalance;
        }
    }

    // public BankAccount(string accNumIn)
    // {
    //     AccountBalance = StartingBalance;
    //     AccountNumber = accNumIn;
    // }

    public abstract void MakeDeposit(decimal amountIn);

    public abstract void MakeWithdrawal(decimal amountIn);

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}\nAccount Balanace: {AccountBalance}";
    }
}
