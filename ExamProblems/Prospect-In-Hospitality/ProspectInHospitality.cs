using System;

class ProspectInHospitality  // https://judge.softuni.bg/Contests/Practice/Index/129#0
{
    static void Main()
    {
        uint builders = uint.Parse(Console.ReadLine());
        uint receptionists = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technicians = uint.Parse(Console.ReadLine());
        uint others = uint.Parse(Console.ReadLine());
        decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
        decimal currencyRate = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal moneyNeeded = 
            (builders * 1500.04M) + (receptionists * 2102.10M) +
            (chambermaids * 1465.46M) + (technicians * 2053.33M) + 
            (others * 3010.98M) + (nikiSalaryUSD * currencyRate) + mySalary;

        Console.WriteLine("The amount is: {0:F2} lv.", moneyNeeded);

        if (budget >= moneyNeeded)
        {
            Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - moneyNeeded);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", moneyNeeded - budget);
        }
    }
}

