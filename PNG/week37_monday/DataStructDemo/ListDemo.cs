static class ListDemo
{
    public static void Run()
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Orange",
        };

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}