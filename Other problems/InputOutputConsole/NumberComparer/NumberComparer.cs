using System;
class NumberComparer
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: {0}", greaterNumber);
    }
}

