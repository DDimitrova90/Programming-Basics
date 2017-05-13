using System;

class Trip
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string vacation = "";
        double costs = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";

            if (season == "summer")
            {
                costs = 0.3 * budget;
                vacation = "Camp";
            }
            else
            {
                costs = 0.7 * budget;
                vacation = "Hotel";
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";

            if (season == "summer")
            {
                costs = 0.4 * budget;
                vacation = "Camp";
            }
            else
            {
                costs = 0.8 * budget;
                vacation = "Hotel";
            }
        }
        else
        {
            destination = "Europe";
            costs = 0.9 * budget;
            vacation = "Hotel";
        }

        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:F2}", vacation, costs);
    }
}

