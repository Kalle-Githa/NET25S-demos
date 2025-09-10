class PersonalAccount : BankAccount
{
    public string CardNumber { get; private set; }

    public PersonalAccount(string accountNumber, double initialBalance, string cardNumber) : base(accountNumber, initialBalance)
    {
        CardNumber = cardNumber;
    }

    public override void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount} from personal account {AccountNumber}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Withdraw amount exceeds balance, try again!");
        }
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Personal account: {AccountNumber}, Balance: {Balance}, Card: {CardNumber}");
    }
}