// basklass. abstract = gör att den inte kan instansieras direkt
abstract class BankAccount
{
    public string AccountNumber { get; private set; } // läsas överallt, ändras från basklassen (härifrån)
    public double Balance { get; protected set; } // läsas överallt, ändras bara från basklass + subklasser

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // virtual metod, kan överskrivas i subklasser
    public virtual void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} to {AccountNumber}. New balance: {Balance}");
    }

    // abstract metod, den MÅSTE implementeras i subklasser
    public abstract void Withdraw(double amount);

    // virtual metod, skriv ut info
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
    }

}