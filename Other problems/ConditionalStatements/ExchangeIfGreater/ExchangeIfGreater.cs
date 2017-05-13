using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double exchange;

        if (firstNumber > secondNumber)
        {
            exchange = secondNumber;
            secondNumber = firstNumber;
            firstNumber = exchange;

            Console.WriteLine(firstNumber + " " + secondNumber);
        }
        else
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}

