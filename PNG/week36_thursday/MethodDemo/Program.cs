class Program
{
  // Metod som tar en int som parameter och returnerar ett värde
  public static int CalculateInvoiceAmount(int invoiceAmount)
  {
    // double result = invoiceAmount * 1.25; // funkar pga double
    int result = invoiceAmount * 1_25; // multiplicera med 1.25
    return result;
  }

  // Metod utan returvärde (void) som bara skriver ut något
  public static void WriteMsg(string text)
  {
    Console.WriteLine(text);
  }

  static void Main()
  {
    // Anropa metoden med parameter och få tillbaka ett returvärde
    int number = 20;
    int returnValue = CalculateInvoiceAmount(number);
    Console.WriteLine(("Fakturabeloppet är: " + returnValue).ToCurrency());

    // Anropa void-metoden
    WriteMsg("\nHej! Detta är ett meddelande från en metod. \n");

    // Testa med flera anrop
    Console.WriteLine("Beräknar fler fakturor:");
    Console.WriteLine(CalculateInvoiceAmount(50).ToCurrency());
    Console.WriteLine(CalculateInvoiceAmount(100).ToCurrency());
  }
}
