using System;

class SmartLilly         // https://judge.softuni.bg/Contests/Practice/Index/181#3
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double laundryPrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toys = 0;
        int money = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 != 0)
            {
                toys++;               
            }
            else
            {
                money += (i / 2) * 10;
                money--;
            }
        }

        int toysProfit = toys * toyPrice;
        int totalMoney = toysProfit + money;
        double result = Math.Abs(totalMoney - laundryPrice);

        if (totalMoney >= laundryPrice)
        {
            Console.WriteLine("Yes! {0:F2}", result);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", result);
        }
    }
}

