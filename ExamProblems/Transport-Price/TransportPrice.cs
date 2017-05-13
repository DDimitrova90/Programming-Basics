using System;

class TransportPrice           //https://judge.softuni.bg/Contests/Practice/Index/169#1  06.03.2016
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();

        double taxiPrice = 0.70;
        double busPrice = 0.09 * km;
        double trainPrice = 0.06 * km;

        if (km < 20)
        {     
            if (time == "day")
            {
                taxiPrice += 0.79 * km;
            }
            else
            {
                taxiPrice += 0.90 * km;
            }

            Console.WriteLine(taxiPrice);
        }

        else if ((km >= 20) && (km < 100))
        {           
            if (time == "day")
            {
                taxiPrice += 0.79 * km;
            }
            else
            {
                taxiPrice += 0.90 * km;
            }

            Console.WriteLine(Math.Min(busPrice, taxiPrice));
        }

        else
        {
            if (time == "day")
            {
                taxiPrice += 0.79 * km;
            }
            else
            {
                taxiPrice += 0.90 * km;
            }

            double cheaper = Math.Min(taxiPrice, busPrice);
            Console.WriteLine(Math.Min(cheaper, trainPrice));
        }
    }
}

