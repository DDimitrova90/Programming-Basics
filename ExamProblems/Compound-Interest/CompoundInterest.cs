using System;

class CompoundInterest    // https://judge.softuni.bg/Contests/Practice/Index/82#0
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int term = int.Parse(Console.ReadLine());
        double interestRate = double.Parse(Console.ReadLine());
        double percentageFriend = double.Parse(Console.ReadLine());

        double futureVal = tvPrice * Math.Pow((1 + interestRate), term);
        double friendsLoan = tvPrice * (1 + percentageFriend);

        if (futureVal < friendsLoan)
        {
            Console.WriteLine("{0:F2} Bank", futureVal);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendsLoan);
        }
    }
}

