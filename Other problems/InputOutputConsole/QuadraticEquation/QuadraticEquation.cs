using System;
class QuadraticEquation
{
    static void Main()
    {
        double firstCoeff = double.Parse(Console.ReadLine());
        double secondCoeff = double.Parse(Console.ReadLine());
        double thirdCoeff = double.Parse(Console.ReadLine());
        double deskreminanta = Math.Pow(secondCoeff, 2) - (4 * firstCoeff * thirdCoeff);
        double firstRoot = (-secondCoeff - Math.Sqrt(deskreminanta)) / (2 * firstCoeff);
        double secondRoot = (-secondCoeff + Math.Sqrt(deskreminanta)) / (2 * firstCoeff);

        if (deskreminanta < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (deskreminanta > 0)
        {
            Console.WriteLine("x1 = {0}; x2 = {1}", firstRoot, secondRoot);
        }
        else 
        {
            Console.WriteLine("x1 = x2 = {0}", firstRoot, secondRoot);
        }
    }
}

