using System.Collections;

class Program
{
    static void Main()
    {
        // Enkel array
        int[] numbers = [1, 3, 45, 5];
        Console.WriteLine("Första värdet: " + numbers[0]); // 1
        Console.WriteLine("Tredje värdet: " + numbers[2]); // 45
        Console.WriteLine("Sista värdet: " + numbers[numbers.Length - 1]); // 5

        // Enkel lista
        List<int> list = [1, 2, 3, 4];
        Console.WriteLine("Listan innehåller " + list.Count + " värden.");
        list.Insert(0, 5);
        Console.WriteLine("Listan innehåller " + list.Count + " värden.");

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        // Deklarera först, fyll sedan
        int[] moreNumbers = new int[4];
        moreNumbers[0] = 10;
        moreNumbers[1] = 20;
        moreNumbers[2] = 30;
        moreNumbers[3] = 40;

        // Array längd och loop
        Console.WriteLine("\nLoopar igenom numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i} = {numbers[i]}");
        }

        // while-loop som alternativ
        Console.WriteLine("\nLoopar igenom moreNumbers med while:");
        int counter = 0;
        while (counter < moreNumbers.Length)
        {
            Console.WriteLine($"Index {counter} = {moreNumbers[counter]}");
            counter++;
        }

        // Tvådimensionell array
        int[,] table = new int[3, 2];

        table[0, 0] = 1;
        table[0, 1] = 21;

        table[1, 0] = 5;
        table[1, 1] = 8;

        table[2, 0] = 1;
        table[2, 1] = 3;

        Console.WriteLine("\nTvådimensionell array (3x2):");
        for (int row = 0; row < table.GetLength(0); row++) // raden
        {
            for (int col = 0; col < table.GetLength(1); col++) // kolumnen
            {
                Console.Write(table[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}