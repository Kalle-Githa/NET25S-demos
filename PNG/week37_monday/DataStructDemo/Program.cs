
class Program
{
    static void Main()
    {
        Console.WriteLine("-- List Demo --");
        ListDemo.Run();

        Console.WriteLine("\n-- Stack Demo (LIFO) --");
        StackDemo.Run();

        Console.WriteLine("\n-- Queue Demo (FIFO) --");
        QueueDemo.Run();

        Console.WriteLine("\n-- Dictionary Demo --");
        DictDemo.Run();
    }
}