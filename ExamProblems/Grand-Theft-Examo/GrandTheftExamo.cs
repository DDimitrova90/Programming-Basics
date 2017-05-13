using System;

class GrandTheftExamo  // https://judge.softuni.bg/Contests/Practice/Index/119#1
{
    static void Main()
    {
        long escapeAttempts = long.Parse(Console.ReadLine());

        long beerDrunk = 0;
        long slappedThieves = 0;
        long escapedThieves = 0;

        for (int i = 0; i < escapeAttempts; i++)
        {
            long thieves = long.Parse(Console.ReadLine());
            long beers = long.Parse(Console.ReadLine());

            beerDrunk += beers;

            if (thieves <= 5)
            {
                slappedThieves += thieves;
            }
            else
            {
                slappedThieves += 5;
                escapedThieves += thieves - 5;
            }
        }

        long sixpacks = beerDrunk / 6;
        long bottles = beerDrunk % 6;

        Console.WriteLine("{0} thieves slapped.", slappedThieves);
        Console.WriteLine("{0} thieves escaped.", escapedThieves);
        Console.WriteLine("{0} packs, {1} bottles.", sixpacks, bottles);
    }
}

