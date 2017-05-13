using System;

class BookProblem     // https://judge.softuni.bg/Contests/Practice/Index/81#0
{
    static void Main()
    {
        int allPages = int.Parse(Console.ReadLine());
        int campDays = int.Parse(Console.ReadLine());
        int pagesPerDay = int.Parse(Console.ReadLine());

        if (campDays == 30)
        {
            Console.WriteLine("never");
        }
        else
        {
            int daysForRead = 30 - campDays;
            int pagesPerMonth = daysForRead * pagesPerDay;
            double neededTime = (double)allPages / pagesPerMonth;
            int years = (int)neededTime / 12;
            double months = neededTime % 12;
            Console.WriteLine("{0} years {1} months", years, Math.Ceiling(months));
        }
    }
}

