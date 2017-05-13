using System;

class Volleyball      // https://judge.softuni.bg/Contests/Practice/Index/3#0
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int normalWeekends = 48 - hometownWeekends;
        double timesToPlay = 
            ((2.0 / 3) * holidays) + 
            hometownWeekends + 
            ((3.0 / 4) * normalWeekends);

        Console.WriteLine(
            yearType == "normal" 
            ? Math.Floor(timesToPlay) 
            : Math.Floor(1.15 * timesToPlay));
    }
}

