using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        int weekendsSf = 48 - weekendsHome;
        double playSf = (3.0 / 4) * weekendsSf;  //stava i po dvata nachina, no tr da e drobno delene
        double playHolidays =  (2 / 3d) * holidays;
        double totalPlay = playSf + playHolidays + weekendsHome;

        if (yearType == "leap")
        {
            totalPlay += 0.15 * totalPlay;
            Console.WriteLine(Math.Floor(totalPlay));
        }
        else
        {
            Console.WriteLine(Math.Truncate(totalPlay));  //i tova zakryglq do cqlo chislo
        }
    }
}

