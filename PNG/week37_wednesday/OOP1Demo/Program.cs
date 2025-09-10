class Program
{
    static void Main()
    {
        // Create a new object, instancing Account class
        Account newAcc = new Account("degen", "degen", "degen@mail.com");

        Console.WriteLine("-- New account has been created --");
        newAcc.ShowInfo();

        Console.WriteLine("\n-- Login --");
        Console.Write("Username: ");
        string? user = Console.ReadLine();
        Console.Write("Password: ");
        string pwd = ConsoleHelper.MaskPassword();

        if (newAcc.Login(user ?? "", pwd ?? ""))
        {
            Console.WriteLine("✅ Login succesful!");
            Console.WriteLine("\n-- Updating some data --");
            newAcc.UpdateUser("foo", "foo@bar.io", true);
            newAcc.ShowInfo();

            Console.WriteLine("\n-- Unregistering account");
            newAcc.Unregister();
        }
        else
        {
            Console.WriteLine("❌ Login failed, try again.");
            Main(); // vi går inte ur programmet
        }
    }
}