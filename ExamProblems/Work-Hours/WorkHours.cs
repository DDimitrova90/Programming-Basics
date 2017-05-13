using System;

class WorkHours    // https://judge.softuni.bg/Contests/Practice/Index/4#0
{
    static void Main()
    {
        int hoursNeeded = int.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());

        double totalWorkTime = workDays * 12 * 0.9 * (productivity / 100d);

        Console.WriteLine(totalWorkTime >= hoursNeeded ? "Yes" : "No");
        Console.WriteLine(Math.Floor(totalWorkTime) - hoursNeeded);
    }
}
