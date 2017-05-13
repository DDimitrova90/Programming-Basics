using System;

class PiggyBank     // https://judge.softuni.bg/Contests/Practice/Index/53#0
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int randomDays = 30 - partyDays;
        int savedMoneyPerMonth = (randomDays * 2) - (partyDays * 5);

        double monthsNeeded = (double)tankPrice / savedMoneyPerMonth;
        double years = monthsNeeded / 12;
        double months = monthsNeeded % 12;
        years = Math.Floor(years);
        months = Math.Ceiling(months);

        if (savedMoneyPerMonth <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            if (months == 12)
            {
                years++;
                months = 0;
            }

            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}

