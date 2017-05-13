using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time in format \"hh:mm tt\": ");
        string dateString = Console.ReadLine();
        string format = "h:mm tt";
        DateTime dateTime;

        if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
        {
            string partOfDay = dateTime.ToString("tt", CultureInfo.InvariantCulture);
            if ((partOfDay == "PM" && dateTime.Hour >= 1) || (partOfDay == "AM" && dateTime.Hour < 3))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

