class Helper
{
    public static void DateDemo()
    {
        // Skapa datum
        DateTime myDate = new DateTime(2025, 9, 4, 11, 0, 0);
        Console.WriteLine(myDate);

        // Ta ut delar
        Console.WriteLine($"År: {myDate.Year}, Månad: {myDate.Month}, Dag: {myDate.Day}");

        // Ändra datum
        DateTime plus20 = myDate.AddDays(20);
        Console.WriteLine($"+20 dagar: {plus20.ToShortDateString()}");

        DateTime minus7 = myDate.AddDays(-7);
        Console.WriteLine($"-7 dagar: {minus7.ToShortDateString()}");

        // Jämföra
        DateTime d1 = new(2025, 10, 22);
        DateTime d2 = new(2025, 10, 20);
        int compareDates = DateTime.Compare(d1, d2);
        Console.WriteLine($"Jämförelse d1 vs d2: {compareDates}");

        TimeSpan diff = d1 - d2;
        Console.WriteLine($"Skillnad: {diff.Days} dagar");
    }

    public static void StringDemo()
    {
        string country = "Sverige";
        string city = "Stockholm";

        // Konkatenering
        string dest1 = "Landet är: " + country + " och staden är: " + city;
        string dest2 = $"Landet är: {country} och staden är: {city}";
        Console.WriteLine(dest1);
        Console.WriteLine(dest2);

        // Dela upp en sträng
        string mail = "lisa.lind@jensen.se";
        int pos = mail.IndexOf("@");
        string firstPart = mail.Substring(0, pos);
        string lastPart = mail.Substring(pos + 1);
        Console.WriteLine($"Mail före @ {firstPart} och efter @ {lastPart}");

        // Sök i sträng
        Console.Write("Skriv något: ");
        string searchTerm = Console.ReadLine() ?? "";
        // Ifall searchTerm är null så kommer ToLower() krascha, därav simpelt kontrollflöde
        if (!string.IsNullOrEmpty(searchTerm))
        {
            string product = "Samsung Galaxy S20";
            var match = product.ToLower().Contains(searchTerm.ToLower());
            var result = match ? "Japp!" : "Nej";
            Console.WriteLine($"Träff på {searchTerm} i {product}? {result}");
        }
    }
}