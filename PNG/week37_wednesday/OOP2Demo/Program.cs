class Program
{
    static void Main()
    {
        // // arv + polymorfism
        // BankAccount personalAcc = new PersonalAccount("P-891012", 1337.37, "1234-567-890");
        // BankAccount savingsAcc = new SavingsAccount("S-891012", 5000);

        // personalAcc.ShowInfo();
        // savingsAcc.ShowInfo();

        // Console.WriteLine("\n-- Transactions --");
        // personalAcc.Deposit(500);
        // personalAcc.Withdraw(300);
        // personalAcc.Withdraw(2000);

        // savingsAcc.Deposit(1000);
        // savingsAcc.Withdraw(200);
        // savingsAcc.Withdraw(200);
        // savingsAcc.Withdraw(200);
        // savingsAcc.Withdraw(200);
        // savingsAcc.Withdraw(200); // should hit limit????

        // Console.WriteLine("\n-- After transactions --");
        // personalAcc.ShowInfo();
        // savingsAcc.ShowInfo();

        Console.WriteLine("\n-- Overloading --");
        Console.WriteLine($"Add med 2 ints: {Calculator.Add(2, 3)}");
        Console.WriteLine($"Add med doubles: {Calculator.Add(2.72, 3.54)}");
        Console.WriteLine($"Add med 3 ints: {Calculator.Add(2, 3, 4)}");
    }
}