using System;

class BaiIvanAdventures   // https://judge.softuni.bg/Contests/Practice/Index/102#0
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());
        decimal litersToDrink = decimal.Parse(Console.ReadLine());

        decimal litersPaid = 0;
        string condition = "";

        switch (dayOfWeek)
        {
            case 0:
                litersPaid = money / 25.0M;
                break;
            case 1:
                litersPaid = money / 21.0M;
                break;
            case 2: 
                litersPaid = money / 14.0M;
                break;
            case 3:
                litersPaid = money / 17.0M;
                break;
            case 4:
                litersPaid = money / 45.0M;
                break;
            case 5:
                litersPaid = money / 59.0M;
                break;
            case 6:
                litersPaid = money / 42.0M;
                break;
        }

        if (litersPaid > 1.5M)
        {
            condition = "very drunk";
        }
        else if (litersPaid <= 1.5M && litersPaid >= 1.0M)
        {
            condition = "drunk";
        }
        else
        {
            condition = "sober";
        }

        if (litersPaid > litersToDrink)
        {
            Console.WriteLine(
                "Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",
                condition, litersPaid - litersToDrink);
        }
        else if (litersPaid == litersToDrink)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        }
        else
        {
            Console.WriteLine(
                "Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", 
                condition, litersToDrink - litersPaid);
        }
    }
}

