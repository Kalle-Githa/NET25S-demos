static class DictDemo
{
    public static void Run()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            ["Alice"] = 2,
            ["Sebastian"] = 35
        };

        Console.WriteLine($"Alice age: {ages["Alice"]}");

        // kvp = key-value-pair
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key} is {kvp.Value} years old");
        }
    }
}