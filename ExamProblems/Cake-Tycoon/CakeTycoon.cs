using System;

class CakeTycoon    // https://judge.softuni.bg/Contests/Practice/Index/149#0
{
    static void Main()
    {
        ulong cakesWanted = ulong.Parse(Console.ReadLine());
        double flourPerCake = double.Parse(Console.ReadLine());
        uint flourKilos = uint.Parse(Console.ReadLine());
        uint trufflesAmount = uint.Parse(Console.ReadLine());
        uint trufflePrice = uint.Parse(Console.ReadLine());

        double cakeNum = Math.Floor(flourKilos / flourPerCake);
        ulong truffleCost = (ulong)trufflesAmount * trufflePrice;
        double cakePrice = ((double)truffleCost / cakesWanted) * 1.25d;
        double flourNeeded = (cakesWanted * flourPerCake) - flourKilos;

        if (cakeNum >= cakesWanted)
        {
            Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
        }
        else
        {
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakeNum, flourNeeded);
        }       
    }
}

