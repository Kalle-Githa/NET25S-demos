class Program
{
    static void Main()
    {
        // Fråga användaren efter filnamn, skapas i projektmappen
        Console.Write("Välj ett filnamn: ");
        string? fileName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(fileName)) // vi förväntar oss ett filnamn
        {
            string file = $"{fileName}.txt";

            // Skriva till filen
            using (StreamWriter writer = new(file, append: true))
            {
                writer.WriteLine("Hej NET25S!");
                writer.WriteLine($"Idag är det {DateTime.Now}");
            }

            Console.WriteLine($"Text har skrivits till {file}.\n");

            // Läs från filen
            using (StreamReader reader = new(file))
            {
                string? line;
                Console.WriteLine("Innehåll i filen:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            WriteUserInput(file);
        }
    }

    static void WriteUserInput(string file)
    {
        Console.WriteLine("\nSkriv en rad att lägga till i filen (eller lämna tomt för att avsluta):");

        string? input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            using (StreamWriter writer = new(file, true))
            {
                writer.WriteLine(input);
            }
            Console.WriteLine("Din text sparades!\n");

            Console.WriteLine("Aktuellt innehåll i filen:");
            using (StreamReader reader = new(file))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}