using System;

class OnTimeForTheExam     // https://judge.softuni.bg/Contests/Practice/Index/169#2  06.03.2016
{
    static void Main()
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minExam = int.Parse(Console.ReadLine());
        int hourArrive = int.Parse(Console.ReadLine());
        int minArrive = int.Parse(Console.ReadLine());

        int timeExam = (hourExam * 60) + minExam;
        int timeArrive = (hourArrive * 60) + minArrive;
        int minDiff = timeArrive - timeExam;
        int hours = 0;
        int mins = 0;

        if (minDiff < -30)
        {
            Console.WriteLine("Early");
        }
        else if ((minDiff >= -30) && (minDiff <= 0))
        {
            Console.WriteLine("On time");
        }
        else
        {
            Console.WriteLine("Late");
        }

        if ((minDiff > -60) && (minDiff < 0))
        {
            Console.WriteLine("{0} minutes before the start", Math.Abs(minDiff));
        }
        else if (minDiff <= -60)
        {
            hours = Math.Abs(minDiff) / 60;
            mins = Math.Abs(minDiff) % 60;
            Console.WriteLine("{0}:{1:00} hours before the start", hours, mins);
        }
        else if ((minDiff < 60) && (minDiff > 0))
        {
            Console.WriteLine("{0} minutes after the start", minDiff);
        }
        else if (minDiff >= 60)
        {
            hours = minDiff / 60;
            mins = minDiff % 60;
            Console.WriteLine("{0}:{1:00} hours after the start", hours, mins);
        }
    }
}

