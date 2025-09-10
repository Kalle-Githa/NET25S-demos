class Program
{
    static void Main()
    {
        // // FOR LOOP
        // Console.WriteLine("For loop: count from 1 to 10");
        // for (int i = 1; i <= 10; i++)
        // {
        //     // if (i == 2) continue; // hoppa över enligt villkor
        //     // break; // går ur loopen
        //     Console.WriteLine(i);
        // }

        // WHILE LOOP
        Console.WriteLine("\nWhile loop: count from 1 to 10");
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine(j);
            j++;
        }

        // // FOREACH LOOP
        // Console.WriteLine("\nForeach loop: print each letter in a string");
        // string greetings = "Hello NET25S!";
        // foreach (char letter in greetings)
        // {
        //     Console.WriteLine(letter);
        // }

        // // BREAK EXAMPLE
        // Console.WriteLine("\nBreak example: stop loop when i == 5");
        // for (int k = 0; k <= 10; k++)
        // {
        //     if (k == 5)
        //     {
        //         Console.WriteLine("k is " + k + ", breaking loop!");
        //         break;
        //     }
        //     Console.WriteLine(k);
        //     //Testar om jag kan pusha detta :)
        // }
    }
}
