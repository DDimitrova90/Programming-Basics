using System;

class FruitMarket     // https://judge.softuni.bg/Contests/Practice/Index/8#0
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        decimal bananaPrice = 1.80m;
        decimal cucumberPrice = 2.75m;
        decimal tomatoPrice = 3.20m;
        decimal orangePrice = 1.60m;
        decimal applePrice = 0.86m;

        switch (dayOfWeek)
        {
            case "Friday":
                bananaPrice *= 0.9m;
                cucumberPrice *= 0.9m;
                tomatoPrice *= 0.9m;
                orangePrice *= 0.9m;
                applePrice *= 0.9m;
                break;
            case "Sunday":
                bananaPrice *= 0.95m;
                cucumberPrice *= 0.95m;
                tomatoPrice *= 0.95m;
                orangePrice *= 0.95m;
                applePrice *= 0.95m;
                break;
            case "Tuesday":
                bananaPrice *= 0.8m;
                orangePrice *= 0.8m;
                applePrice *= 0.8m;
                break;
            case "Wednesday":
                cucumberPrice *= 0.9m;
                tomatoPrice *= 0.9m;
                break;
            case "Thursday":
                bananaPrice *= 0.7m;
                break;
        }

        decimal price1 = 0;
        decimal price2 = 0;
        decimal price3 = 0;

        switch (product1)
        {
            case "banana":
                price1 = bananaPrice;
                break;
            case "cucumber":
                price1 = cucumberPrice;
                break;
            case "tomato":
                price1 = tomatoPrice;
                break;
            case "orange":
                price1 = orangePrice;
                break;
            case "apple":
                price1 = applePrice;
                break;
        }

        switch (product2)
        {
            case "banana":
                price2 = bananaPrice;
                break;
            case "cucumber":
                price2 = cucumberPrice;
                break;
            case "tomato":
                price2 = tomatoPrice;
                break;
            case "orange":
                price2 = orangePrice;
                break;
            case "apple":
                price2 = applePrice;
                break;
        }

        switch (product3)
        {
            case "banana":
                price3 = bananaPrice;
                break;
            case "cucumber":
                price3 = cucumberPrice;
                break;
            case "tomato":
                price3 = tomatoPrice;
                break;
            case "orange":
                price3 = orangePrice;
                break;
            case "apple":
                price3 = applePrice;
                break;
        }

        decimal totalPrice = quantity1 * price1 + quantity2 * price2 + quantity3 * price3;

        Console.WriteLine("{0:F2}", totalPrice);
    }
}

