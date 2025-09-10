class SavingsAccount : BankAccount
{
    private int withdrawalLimit;
    private int withdrawalsMade;
    public SavingsAccount(string accountNumber, double initialBalance, int withdrawalLimit = 3)
        : base(accountNumber, initialBalance)
    {
        this.withdrawalLimit = withdrawalLimit;
        withdrawalsMade = 0;
    }

    public override void Withdraw(double amount)
    {
        if (withdrawalsMade >= withdrawalLimit)
        {
            Console.WriteLine("Withdrawal limit reached!");
            return;
        }

        if (Balance >= amount)
        {
            Balance -= amount;
            withdrawalsMade++;
            Console.WriteLine($"Withdrawn {amount} from savings account {AccountNumber}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Savings account: {AccountNumber}, Balance: {Balance}, Withdrawals left: {withdrawalLimit - withdrawalsMade}");
    }
}