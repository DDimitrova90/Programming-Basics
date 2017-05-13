using System;

class MatchTickets     // https://judge.softuni.bg/Contests/Practice/Index/233#2
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int peopleNum = int.Parse(Console.ReadLine());
        double moneyForTrasnport = 0;

        if (peopleNum >= 1 && peopleNum <= 4)
        {
            moneyForTrasnport = 0.75 * budget;
        }
        else if (peopleNum >= 5 && peopleNum <= 9)
        {
            moneyForTrasnport = 0.60 * budget;
        }
        else if (peopleNum >= 10 && peopleNum <= 24)
        {
            moneyForTrasnport = 0.50 * budget;
        }
        else if (peopleNum >= 25 && peopleNum <= 49)
        {
            moneyForTrasnport = 0.40 * budget;
        }
        else if (peopleNum >= 50)
        {
            moneyForTrasnport = 0.25 * budget;
        }

        double moneyLeft = budget - moneyForTrasnport;
        double ticketsCost = 0;

        if (category == "Normal")
        {
            ticketsCost = peopleNum * 249.99;
        }
        else
        {
            ticketsCost = peopleNum * 499.99;
        }

        if (moneyLeft >= ticketsCost)
        {
            Console.WriteLine("Yes! You have {0:F2} leva left.", 
                moneyLeft - ticketsCost);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:F2} leva.", 
                ticketsCost - moneyLeft);
        }
    }
}

