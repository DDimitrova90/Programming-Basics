using System;

class BabaTincheAirlines    // https://judge.softuni.bg/Contests/Practice/Index/36#0
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        string thirdLine = Console.ReadLine();

        string[] firstClass = firstLine.Split();
        int passengers1 = int.Parse(firstClass[0]);
        int frequentFlyers1 = int.Parse(firstClass[1]);
        int purchasedMeals1 = int.Parse(firstClass[2]);

        string[] businessClass = secondLine.Split();
        int passengers2 = int.Parse(businessClass[0]);
        int frequentFlyers2 = int.Parse(businessClass[1]);
        int purchasedMeals2 = int.Parse(businessClass[2]);

        string[] economyClass = thirdLine.Split();
        int passengers3 = int.Parse(economyClass[0]);
        int frequentFlyers3 = int.Parse(economyClass[1]);
        int purchasedMeals3 = int.Parse(economyClass[2]);

        double incomeFirstClass = (
            (passengers1 - frequentFlyers1) * 7000) + 
            (frequentFlyers1 * (0.3 * 7000)) + 
            (purchasedMeals1 * (0.005 * 7000));
        double incomeBusinessClass = (
            (passengers2 - frequentFlyers2) * 3500) + 
            (frequentFlyers2 * (0.3 * 3500)) + 
            (purchasedMeals2 * (0.005 * 3500));
        double incomeEconomyClass = (
            (passengers3 - frequentFlyers3) * 1000) + 
            (frequentFlyers3 * (0.3 * 1000)) + 
            (purchasedMeals3 * (0.005 * 1000));

        double totalIncome = incomeFirstClass + incomeBusinessClass + incomeEconomyClass;
        double maxTotalIncome = (12 * 1.005 * 7000) + (28 * 1.005 * 3500) + (50 * 1.005 * 1000);

        Console.WriteLine("{0}", (int)totalIncome);
        Console.WriteLine("{0}", Math.Ceiling(maxTotalIncome - totalIncome));
    }
}

