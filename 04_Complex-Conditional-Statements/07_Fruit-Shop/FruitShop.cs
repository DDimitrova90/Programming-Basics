using System;

class FruitShop
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double amount = double.Parse(Console.ReadLine());

        if ((dayOfWeek == "Monday") || (dayOfWeek == "Tuesday") || 
            (dayOfWeek == "Wednesday") || (dayOfWeek == "Thursday") || (dayOfWeek == "Friday"))
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:F2}", 2.50 * amount);
            }
            else if (fruit == "apple")
            {
                Console.WriteLine("{0:F2}", 1.20 * amount);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:F2}", 0.85 * amount);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:F2}", 1.45 * amount);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:F2}", 2.70 * amount);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:F2}", 5.50 * amount);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:F2}", 3.85 * amount);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if ((dayOfWeek == "Saturday") || (dayOfWeek == "Sunday"))
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:F2}", 2.70 * amount);
            }
            else if (fruit == "apple")
            {
                Console.WriteLine("{0:F2}", 1.25 * amount);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:F2}", 0.90 * amount);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:F2}", 1.60 * amount);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:F2}", 3.00 * amount);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:F2}", 5.60 * amount);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:F2}", 4.20 * amount);
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

