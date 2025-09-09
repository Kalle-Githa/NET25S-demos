class Program
{
    static void Main()
    {
        string filePath = "demo.txt";

        // --- Skriv första raden (skapar filen om den inte finns)
        File.WriteAllText(filePath, "Första raden" + Environment.NewLine); // \n är Unix-style radslut

        // --- Lägg till en rad
        File.AppendAllText(filePath, "Andra raden" + Environment.NewLine); // https://stackoverflow.com/questions/1015766/difference-between-n-and-environment-newline

        // --- Läs hela filen
        string allText = File.ReadAllText(filePath);
        Console.WriteLine("All text i filen:\n" + allText);

        // --- Läs rad för rad
        Console.WriteLine("Rader i filen:");
        foreach (var line in File.ReadLines(filePath)) // effektivare än ReadAllLines
        {
            Console.WriteLine($"- {line}");
        }

        // --- Kolla om filen finns
        if (File.Exists(filePath))
        {
            Console.WriteLine($"\nFilen '{filePath}' finns och innehåller {File.ReadAllLines(filePath).Length} rader.");
        }
    }
}