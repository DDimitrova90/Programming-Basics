using System;

class CountBeers     // https://judge.softuni.bg/Contests/Practice/Index/77#0
{
    static void Main()
    {
        string list = Console.ReadLine();
        int stacks = 0;
        int beers = 0;

        while (list != "End")
        { 
            string[] parameters = list.Split();
            int count = int.Parse(parameters[0]);
            string measure = parameters[1];

            if (measure == "stacks")
            {
                stacks += count;
            }
            else
            {
                beers += count;
            }

            list = Console.ReadLine();
        }

        stacks += beers / 20;
        beers = beers % 20;

        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
    }
}

