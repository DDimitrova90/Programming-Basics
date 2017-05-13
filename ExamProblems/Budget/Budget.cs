using System;

class Budget     // https://judge.softuni.bg/Contests/Practice/Index/37#0
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        int weekdaysOut = int.Parse(Console.ReadLine());
        int weekendsHometown = int.Parse(Console.ReadLine());

        double costs = 
            (22 * 10) + 
            (weekdaysOut * Math.Floor(0.03 * budget)) + 
            ((4 - weekendsHometown) * 2 * 20) + 150;
        
        if (costs == budget)
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (costs > budget)
        {
            Console.WriteLine("No, not enough {0}.", Math.Floor(costs - budget));
        }
        else
        {
            Console.WriteLine("Yes, leftover {0}.", Math.Floor(budget - costs));
        } 
    }
}

