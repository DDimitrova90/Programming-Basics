using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
        {
            Console.WriteLine("The biggest number is: " + firstNumber);
        }
        else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
        {
            Console.WriteLine("The biggest number is: " + secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest number is: " + thirdNumber);
        }
    } 
}

