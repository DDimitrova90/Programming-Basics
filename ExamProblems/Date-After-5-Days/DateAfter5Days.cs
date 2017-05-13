using System;

class DateAfter5Days    // https://judge.softuni.bg/Contests/Practice/Index/157#4
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        int afterDays = day + 5;

        if (month == 2)
        {
            if (afterDays > 28)
            {
                month++;
                day = afterDays - 28;
            }
            else
            {
                day = afterDays;
            }
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (afterDays > 30)
            {
                month++;
                day = afterDays - 30;
            }
            else
            {
                day = afterDays;
            }
        }
        else
        {
            if (afterDays > 31)
            {
                if (month == 12)
                {
                    month = 1;
                }
                else
                {
                    month++;
                }
                day = afterDays - 31;    
            }
            else
            {
                day = afterDays;
            }
        }

        Console.WriteLine("{0}.{1:00}", day, month);
    }
}

