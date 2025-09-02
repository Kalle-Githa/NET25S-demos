using System;

class Program
{
    static void Main(string[] args)
    {
        // Exempel på hur det syns är att skriva kommandot:
        // dotnet run -- one two three four
        Console.WriteLine(string.Join(", ", args));

        // Exempel på olika datatyper
        int number = 10;
        double temp = 36.6;
        string name = "Lisa";
        bool hasLicense = true;
        const int testNumber = 123;
        // Nedan går ej pga const
        // testNumber = 456;

        Console.WriteLine("Heltal: " + number);
        Console.WriteLine("Temperatur: " + temp);
        Console.WriteLine("Namn: " + name);
        Console.WriteLine("Har körkort? " + hasLicense);
        Console.WriteLine(testNumber);

        // Operatorer
        int num1 = 5;
        int num2 = 3;
        int sum = num1 + num2;
        int product = num1 * num2;

        Console.WriteLine("num1 + num2 = " + sum);
        Console.WriteLine("num1 * num2 = " + product);

        // Typkonvertering (string → int)
        Console.WriteLine("Mata in ett heltal: ");
        var userInput = Console.ReadLine();
        int convertedNumber = int.Parse(userInput);
        Console.WriteLine("Du skrev: " + convertedNumber);

        // Inkrementering och dekrementering
        int counter = 0;
        counter++;
        Console.WriteLine("counter är " + counter);
        counter--;
        Console.WriteLine("counter är " + counter);
        Console.WriteLine("Testa om jag kan ändra i din repository");
    }
}
