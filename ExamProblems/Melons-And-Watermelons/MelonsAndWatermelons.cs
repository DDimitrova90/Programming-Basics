using System;

class MelonsAndWatermelons    // https://judge.softuni.bg/Contests/Practice/Index/17#0
{
    static void Main()
    {
        int startDay = int.Parse(Console.ReadLine());
        int daysAmount = int.Parse(Console.ReadLine());

        int watermelons = 0;
        int melons = 0;

        for (int i = startDay; i < startDay + daysAmount; i++)
        {
            switch (i % 7)
            {
                case 1:
                    watermelons++;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    watermelons++;
                    melons++;
                    break;
                case 4:
                    watermelons += 2;
                    break;
                case 5:
                    watermelons += 2;
                    melons += 2;
                    break;
                case 6:
                    watermelons++;
                    melons += 2;
                    break;
            }
        }

        if (melons == watermelons)
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        else
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
    }
}

