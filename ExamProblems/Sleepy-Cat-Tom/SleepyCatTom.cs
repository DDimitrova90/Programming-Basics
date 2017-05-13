using System;

class SleepyCatTom          // https://judge.softuni.bg/Contests/Practice/Index/181#1   24.04.2016
{
    static void Main()
    {
        int freeDays = int.Parse(Console.ReadLine());

        int workDays = 365 - freeDays;
        int playWorkDays = workDays * 63;
        int playFreeDays = freeDays * 127;
        int totalPlay = playFreeDays + playWorkDays;
        int limitForPlay = 30000;
        int leftTime = Math.Abs(limitForPlay - totalPlay);
        int hours = leftTime / 60;
        int minutes = leftTime % 60;

        if (totalPlay > limitForPlay)
        {          
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
        }
    }
}

