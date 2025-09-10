class Account
{
    // Properties
    public string Username { get; private set; } // Readable outside, settable inside
    private string Password;                     // Private: cannot be accessed outside class
    public string Email { get; set; }            // Public: read and write freely
    public bool Newsletter { get; set; }         // Simple boolean

    public Account(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
        Newsletter = false; // default value
    }

    // method: simplified login
    public bool Login(string username, string password)
    {
        return Username == username && Password == password;
    }

    // method: simplified update of user
    public void UpdateUser(string newUsername, string newEmail, bool consent)
    {
        Username = newUsername;
        Email = newEmail;
        Newsletter = consent;
    }

    // method simplified unregister of user
    public void Unregister()
    {
        /*
            Du kan sätta newAcc (i Program.cs) till null eller låta GC (Garbage Collectorn) hantera det när det går utanför scope.
            Vi kallar typ ALDRIG på GCn själva.
        */
        Console.WriteLine($"{Username} has been unregistered.");
    }

    // method: show account info (note that password is never shown)
    public void ShowInfo()
    {
        Console.WriteLine($"Username: {Username}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Subscribed to newsletter: {Newsletter}");
    }
}