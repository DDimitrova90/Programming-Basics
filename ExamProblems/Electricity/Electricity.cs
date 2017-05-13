using System;

class Electricity     //https://judge.softuni.bg/Contests/Practice/Index/18#0
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string[] time = Console.ReadLine().Split(':');
        int hours = int.Parse(time[0]);
        int mins = int.Parse(time[1]);
        double consumedWatts = 0;
        double totalWatts = 0;

        if (hours >= 14 && hours <= 18)
        {
            consumedWatts = (2 * 100.53) + (2 * 125.90);
        }
        else if (hours >= 19 && hours <= 23)
        {
            consumedWatts = (7 * 100.53) + (6 * 125.90);
        }
        else if (hours >= 0 && hours <= 8)
        {
            consumedWatts = (1 * 100.53) + (8 * 125.90);
        }

        totalWatts = floors * flats * consumedWatts;
        Console.WriteLine("{0} Watts", Math.Floor(totalWatts));
    }
}

