using System;

class ExamSchedule    // https://judge.softuni.bg/Contests/Practice/Index/7#0
{
    static void Main()
    {
        int startHours = int.Parse(Console.ReadLine());
        int startMins = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int examHours = int.Parse(Console.ReadLine());
        int examMins = int.Parse(Console.ReadLine());

        int totalMins = startMins + examMins;
        int endHours = startHours + examHours + (totalMins / 60);
        int endMins = totalMins % 60;
        
        if (endHours >= 12)
        {

            if (partOfDay == "AM")
            {
                partOfDay = "PM";
            }
            else
            {
                partOfDay = "AM";
            }
        }

        if (endHours > 12)
        {
            endHours = endHours - 12;
        }

        Console.WriteLine("{0:00}:{1:00}:{2}", endHours, endMins, partOfDay);
    }
}

