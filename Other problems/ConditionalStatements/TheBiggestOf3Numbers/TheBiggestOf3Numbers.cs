using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers and I will show you the biggest one: ");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            if (number1 > number3)
            {
                Console.WriteLine("The biggest number is: " + number1);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + number3);
            }
        }
        else
        {
            if (number2 > number3)
            {
                Console.WriteLine("The biggest number is: " + number2);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + number3);
            }
        }
    }
}

