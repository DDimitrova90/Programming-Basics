using System;

class HungryGarfield    //https://judge.softuni.bg/Contests/Practice/Index/163#0
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal rate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        uint pizzaQuantity = uint.Parse(Console.ReadLine());    //с int ми дава 80 точки!
        uint lasagnaQuantity = uint.Parse(Console.ReadLine());
        uint sandwichQuantity = uint.Parse(Console.ReadLine());

        decimal moneyPizza = (pizzaPrice / rate) * pizzaQuantity;
        decimal moneyLasagna = (lasagnaPrice / rate) * lasagnaQuantity;
        decimal moneySandwich = (sandwichPrice / rate) * sandwichQuantity;
        decimal moneyNeeded = moneyPizza + moneyLasagna + moneySandwich;

        if (money >= moneyNeeded)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", 
                money - moneyNeeded);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", 
                moneyNeeded - money);
        }
    }
}

