using System;

class TheBetterMusicProducer   // https://judge.softuni.bg/Contests/Practice/Index/119#0
{
    static void Main()
    {
        int albumsEurope = int.Parse(Console.ReadLine());
        decimal albumPriceEur = decimal.Parse(Console.ReadLine());
        int albumsNorthAmer = int.Parse(Console.ReadLine());
        decimal albumPriceDollars = decimal.Parse(Console.ReadLine());
        int albumsSouthAmer = int.Parse(Console.ReadLine());
        decimal albumPricePesos = decimal.Parse(Console.ReadLine());
        int concertsNum = int.Parse(Console.ReadLine());
        decimal concertProfit = decimal.Parse(Console.ReadLine());

        decimal profitEurope = albumsEurope * (albumPriceEur * 1.94M);
        decimal profitNorthAmer = albumsNorthAmer * (albumPriceDollars * 1.72M);
        decimal profitSouthAmer = albumsSouthAmer * (albumPricePesos / 332.74M);
        decimal totalProfit1 = profitEurope + profitNorthAmer + profitSouthAmer;
        totalProfit1 -= 0.35M * totalProfit1;
        totalProfit1 -= 0.20M * totalProfit1;

        decimal totalProfit2 = concertsNum * (concertProfit * 1.94M);

        if (totalProfit2 > 100000)
        {
            totalProfit2 -= 0.15M * totalProfit2;
        }

        if (totalProfit1 > totalProfit2)
        {
            Console.WriteLine(
                "Let's record some songs! They'll bring us {0:F2}lv.", totalProfit1);
        }
        else
        {
            Console.WriteLine(
                "On the road again! We'll see the world and earn {0:F2}lv.", totalProfit2);
        }
    }
}

