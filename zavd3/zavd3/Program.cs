namespace zavd3;

class Program
{
    static void Main()
    {
        Converter converter = new Converter(37.50m, 39.00m);

        decimal amountInUah = 1000.0m;
        decimal amountInUsd = converter.UahToUsd(amountInUah);
        decimal amountInEur = converter.UahToEur(amountInUah);

        Console.WriteLine($"1000 UAH = {amountInUsd} USD");
        Console.WriteLine($"1000 UAH = {amountInEur} EUR");

        amountInUsd = 50.0m;
        amountInEur = 40.0m;
        amountInUah = converter.UsdToUah(amountInUsd);
        decimal amountInUah2 = converter.EurToUah(amountInEur);

        Console.WriteLine($"50 USD = {amountInUah} UAH");
        Console.WriteLine($"40 EUR = {amountInUah2} UAH");
    }
}