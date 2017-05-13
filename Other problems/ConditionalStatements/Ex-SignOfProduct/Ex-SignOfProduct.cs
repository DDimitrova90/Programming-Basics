using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers: ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if ((firstNumber < 0) ^ (secondNumber < 0) ^ (thirdNumber < 0))  
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Postive");
        }        
    }
}

