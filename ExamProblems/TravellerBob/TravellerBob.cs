using System;

class TravellerBob
{
    static void Main()
    {
        // Input

        string yearType = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        // Calculate travels

        int normalMonths = 12 - contractMonths - familyMonths;
        double contractTravels = 3 * 4 * contractMonths;
        double familyTravels = 2 * 2 * familyMonths;
        double normalTravels = 12 * (3d / 5d) * normalMonths;  
        double totalTravels = contractTravels + familyTravels + normalTravels;

        // Check the year for leap or normal
        // Output

        if (yearType == "leap")
        {
            Console.WriteLine(Math.Floor(totalTravels * 1.05));
        }
        else
        {
            Console.WriteLine(Math.Floor(totalTravels));
        }
    }
}

