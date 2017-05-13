using System;

class SmallShopNew
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double amount = double.Parse(Console.ReadLine());

        if (town == "Sofia")
        {
            switch (product)
            {
                case "coffee": Console.WriteLine(0.50 * amount); break;
                case "water": Console.WriteLine(0.80 * amount); break;
                case "beer": Console.WriteLine(1.20 * amount); break;
                case "sweets": Console.WriteLine(1.45 * amount); break;
                case "peanuts": Console.WriteLine(1.60 * amount); break;
            }
        }
        else if (town == "Plovdiv")
        {
            switch (product)
            {
                case "coffee": Console.WriteLine(0.40 * amount); break;
                case "water": Console.WriteLine(0.70 * amount); break;
                case "beer": Console.WriteLine(1.15 * amount); break;
                case "sweets": Console.WriteLine(1.30 * amount); break;
                case "peanuts": Console.WriteLine(1.50 * amount); break;
            }
        }
        else
        {
            switch (product)
            {
                case "coffee": Console.WriteLine(0.45 * amount); break;
                case "water": Console.WriteLine(0.70 * amount); break;
                case "beer": Console.WriteLine(1.10 * amount); break;
                case "sweets": Console.WriteLine(1.35 * amount); break;
                case "peanuts": Console.WriteLine(1.55 * amount); break;
            }
        }
    }
}

