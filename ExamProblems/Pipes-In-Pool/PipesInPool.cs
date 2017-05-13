using System;

class PipesInPool      // https://judge.softuni.bg/Contests/Practice/Index/179#1  26.03.2016
{
    static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int debitPipe1 = int.Parse(Console.ReadLine());
        int debitPipe2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double waterPipe1 = debitPipe1 * hours;
        double waterPipe2 = debitPipe2 * hours;
        double totalWater = waterPipe1 + waterPipe2;
        double percentPipe1 = (waterPipe1 / totalWater) * 100;
        double percentPipe2 = (waterPipe2 / totalWater) * 100;
        double percentTotalWater = (totalWater / volume) * 100;

        if (totalWater <= volume)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",  
                (int)percentTotalWater, (int)percentPipe1, (int)percentPipe2);
        }
        else
        {
            double overflow = totalWater - volume;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                hours, overflow);
        }
    }
}

