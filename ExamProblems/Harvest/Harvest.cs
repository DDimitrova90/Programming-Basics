using System;

class Harvest    // https://judge.softuni.bg/Contests/Practice/Index/233#1
{
    static void Main()
    {
        int vineyardArea = int.Parse(Console.ReadLine());
        double grapePerKvM = double.Parse(Console.ReadLine());
        int litrasWineNeeded = int.Parse(Console.ReadLine());
        int workersNum = int.Parse(Console.ReadLine());

        double totalProducedGrape = vineyardArea * grapePerKvM;
        double grapeForWine = 0.40 * totalProducedGrape;
        double litrasWineProduced = grapeForWine / 2.5;

        if (litrasWineProduced < litrasWineNeeded)
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", 
                Math.Floor(litrasWineNeeded - litrasWineProduced));
        }
        else
        {
            double leftWine = litrasWineProduced - litrasWineNeeded;
            double winePerWorker = leftWine / workersNum;

            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", 
                Math.Floor(litrasWineProduced));
            Console.WriteLine("{0} liters left -> {1} liters per person.", 
                Math.Ceiling(leftWine), Math.Ceiling(winePerWorker));
        }
    }
}

