using System;

class TorrentPirate     // https://judge.softuni.bg/Contests/Practice/Index/78#0
{
    static void Main()
    {
        int mbToDownload = int.Parse(Console.ReadLine());
        int moviePriceCinema = int.Parse(Console.ReadLine());
        int wifeSpendPerHour = int.Parse(Console.ReadLine());

        decimal downloadTime = ((mbToDownload / 2M) / 60M) / 60M;
        decimal downloadPrice = downloadTime * wifeSpendPerHour;
        decimal movieNum = mbToDownload / 1500M;
        decimal cinemaPrice = movieNum * (decimal)moviePriceCinema;

        if (downloadPrice <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:F2}lv", downloadPrice);
        }
        else
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
    }
}

