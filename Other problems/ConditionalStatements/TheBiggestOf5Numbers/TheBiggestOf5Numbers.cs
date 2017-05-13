using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers and I will show you the biggest one: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3) && (num1 > num4) && (num1 > num5))
        {
            Console.WriteLine("The biggest number is: " + num1);
        }
        else if ((num2 > num3) && (num2 > num4) && (num2 > num5))
        {
            Console.WriteLine("The biggest number is: " + num2);
        }
        else if ((num3 > num4) && (num3 > num5))
        {
            Console.WriteLine("The biggest number is: " + num3);
        }
        else if (num4 > num5)
        {
            Console.WriteLine("The biggest number is: " + num4);
        }
        else
        {
            Console.WriteLine("The biggest number is: " + num5);
        }
    }
}

