class Program
{
    static void Main()
    {
        // Create a new object, instancing Account class
        Account newAcc = new Account("degen", "degen", "degen@mail.com");

        // Console.Write("Ange användarnamn: ");
        // string username = Console.ReadLine();

        // Console.Write("Ange lösenord: ");
        // string password = Console.ReadLine();

        // Console.Write("Ange e-postadress: ");
        // string email = Console.ReadLine();

        // Account newAcc = new Account(username, password, email);

        // Console.WriteLine("Konto skapat för: " + newAcc.Username);

        Console.WriteLine("-- New account has been created --");
        newAcc.ShowInfo();

        Console.WriteLine("\n-- Login --");
        Console.Write("Username: ");
        string? user = Console.ReadLine();
        Console.Write("Password: ");
        string pwd = ConsoleHelper.MaskPassword();

        if (newAcc.Login(user ?? "", pwd ?? "")) // om user är null alså man bara tryckte enter, då lägg en tom string "" för att undervika felmedelade NullReferenceException
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
