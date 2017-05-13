using System;

class BackToThePast    // https://judge.softuni.bg/Contests/Practice/Index/233#3
{
    static void Main()
    {
        decimal inheritedMoney = decimal.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());
        decimal costs = 0;
        int age = 17;

        for (int i = 1800; i <= yearToLive; i++)
        {
            age++;

            if (i % 2 == 0)
            {
                costs += 12000;
            }
            else
            {
                costs += 12000 + (50 * age);
            }
        }

        if (inheritedMoney >= costs)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", inheritedMoney - costs);
        }
        else
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", costs - inheritedMoney);
        }
    }
}

