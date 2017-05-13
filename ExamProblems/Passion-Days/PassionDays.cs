using System;

class PassionDays     // https://judge.softuni.bg/Contests/Practice/Index/163#3
{
    static void Main(string[] args)
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        int purchases = 0;

        command = Console.ReadLine();

        while (command != "mall.Exit")
        {
            string actions = command;

            for (int i = 0; i < actions.Length; i++)
            {
                decimal price = 0;
                if (actions[i] >= 65 && actions[i] <= 90)
                {
                    price = 0.50M * actions[i];
                    if (money < price)
                    {
                        continue;
                    }
                    else
                    {
                        money -= price;
                        purchases++;
                    }
                }
                else if (actions[i] >= 97 && actions[i] <= 122)
                {
                    price = 0.30M * actions[i];
                    if (money < price)
                    {
                        continue;
                    }
                    else
                    {
                        money -= price;
                        purchases++;
                    }
                }
                else if (actions[i] == '%')
                {
                    if (money > 0)
                    {
                        money /= 2;
                        purchases++;
                    }
                }
                else if (actions[i] == '*')
                {
                    money += 10;
                }
                else
                {
                    price = actions[i];
                    if (money < price)
                    {
                        continue;
                    }
                    else
                    {
                        money -= price;
                        purchases++;
                    }
                }
            }

            command = Console.ReadLine();
        }

        if (purchases == 0)
        {
            Console.WriteLine($"No purchases. Money left: {money:F2} lv.");
        }
        else
        {
            Console.WriteLine($"{purchases} purchases. Money left: {money:F2} lv.");
        }     
    }
}
