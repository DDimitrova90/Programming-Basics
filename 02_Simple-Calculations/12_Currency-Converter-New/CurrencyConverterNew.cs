using System;

class CurrencyConverterNew
{
    static void Main()
    {
        decimal value = decimal.Parse(Console.ReadLine());
        string currencyFrom = Console.ReadLine();
        string currencyTo = Console.ReadLine();

        if (currencyFrom == "BGN")
        {
            value = value * 1;
        }
        else if (currencyFrom == "USD")
        {
            value = value * 1.79549M;
        }
        else if (currencyFrom == "EUR")
        {
            value = value * 1.95583M;
        }
        else if (currencyFrom == "GBP")
        {
            value = value * 2.53405M;
        }


        if (currencyTo == "BGN")
        {
            value = value / 1;
        }
        else if (currencyTo == "USD")
        {
            value = value / 1.79549M;
        }
        else if (currencyTo == "EUR")
        {
            value = value / 1.95583M;
        }
        else if (currencyTo == "GBP")
        {
            value = value / 2.53405M;
        }

        Console.WriteLine("{0:F2} {1}", value, currencyTo);
    }
}

