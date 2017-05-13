using System;

class DreamItem      // https://judge.softuni.bg/Contests/Practice/Index/79#1
{
    static void Main()
    {
        string inputData = Console.ReadLine();
        string[] parameters = inputData.Split('\\');
        string month = parameters[0];
        decimal moneyPerHour = decimal.Parse(parameters[1]);
        int hoursPerDay = int.Parse(parameters[2]);
        decimal itemPrice = decimal.Parse(parameters[3]);

        decimal totalMoney = 0;

        switch (month)
        {
            case "Feb":
                totalMoney = (28 - 10) * hoursPerDay * moneyPerHour;
                break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                totalMoney = (30 - 10) * hoursPerDay * moneyPerHour;
                break;
            default:
                totalMoney = (31 - 10) * hoursPerDay * moneyPerHour;
                break;
        }

        if (totalMoney > 700)
        {
            totalMoney += 0.1M * totalMoney;
        }

        if (totalMoney >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", totalMoney - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - totalMoney);
        }
    }
}

