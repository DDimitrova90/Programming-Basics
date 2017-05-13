using System;

class TradeComissions
{
    static void Main()
    {
        string town = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        if (town == "Sofia")
        {
            if ((sales >= 0) && (sales <= 500))
            {
                Console.WriteLine("{0:F2}", 0.05 * sales);
            }
            else if ((sales > 500) && (sales <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.07 * sales);
            }
            else if ((sales > 1000) && (sales <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.08 * sales);
            }
            else if (sales > 10000)
            {
                Console.WriteLine("{0:F2}", 0.12 * sales);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "Varna")
        {
            if ((sales >= 0) && (sales <= 500))
            {
                Console.WriteLine("{0:F2}", 0.045 * sales);
            }
            else if ((sales > 500) && (sales <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.075 * sales);
            }
            else if ((sales > 1000) && (sales <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.1 * sales);
            }
            else if (sales > 10000)
            {
                Console.WriteLine("{0:F2}", 0.13 * sales);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "Plovdiv")
        {
            if ((sales >= 0) && (sales <= 500))
            {
                Console.WriteLine("{0:F2}", 0.055 * sales);
            }
            else if ((sales > 500) && (sales <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.08 * sales);
            }
            else if ((sales > 1000) && (sales <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.12 * sales);
            }
            else if (sales > 10000)
            {
                Console.WriteLine("{0:F2}", 0.145 * sales);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

