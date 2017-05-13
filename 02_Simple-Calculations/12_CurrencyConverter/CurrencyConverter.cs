using System;

class CurrencyConverter  
{
    static void Main()
    {
        decimal value = decimal.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();

        decimal bgnToUSD = value / 1.79549M;
        decimal bgnToEUR = value / 1.95583M;
        decimal bgnToGBP = value / 2.53405M;
        decimal usdToBGN = value / 0.55695M;
        decimal eurToBGN = value / 0.51129M;
        decimal gbpToBGN = value / 0.39463M;
        decimal usdToEUR = value / 1.08930M;
        decimal eurToUSD = value / 0.91802M;
        decimal usdToGBP = value / 1.41134M;
        decimal gbpToUSD = value / 0.70855M;
        decimal eurToGBP = value / 1.29564M;
        decimal gbpToEUR = value / 0.77182M;

        if (inputCurrency == "BGN")
        {
            if (outputCurrency == "USD")
            {
                Console.WriteLine("{0:F2} USD", bgnToUSD);   
            }
            else if (outputCurrency == "EUR")
            {
                Console.WriteLine("{0} EUR", Math.Round(bgnToEUR, 2));
            }
            else
            {
                Console.WriteLine("{0} GBP", Math.Round(bgnToGBP, 2));
            }
        }
        else if (inputCurrency == "USD")
        {
            if (outputCurrency == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(usdToBGN, 2));
            }
            else if (outputCurrency == "EUR")
            {
                Console.WriteLine("{0} EUR", Math.Round(usdToEUR, 2));
            }
            else
            {
                Console.WriteLine("{0} GBP", Math.Round(usdToGBP, 2));
            }
        }
        else if (inputCurrency == "EUR")
        {
            if (outputCurrency == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(eurToBGN, 2));
            }
            else if (outputCurrency == "USD")
            {
                Console.WriteLine("{0} USD", Math.Round(eurToUSD, 2));
            }
            else
            {
                Console.WriteLine("{0} GBP", Math.Round(eurToGBP, 2));
            }
        }
        else
        {
            if (outputCurrency == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(gbpToBGN, 2));
            }
            else if (outputCurrency == "USD")
            {
                Console.WriteLine("{0} USD", Math.Round(gbpToUSD, 2));
            }
            else
            {
                Console.WriteLine("{0} EUR", Math.Round(gbpToEUR, 2));
            }
        }
    }
}

