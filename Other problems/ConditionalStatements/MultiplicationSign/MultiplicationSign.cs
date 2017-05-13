using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers and I will tell you what is the sign of the product from them: ");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

        if ((number1 < 0) && (number2 > 0) && (number3 > 0))
        {
            Console.WriteLine("-");
        }
        else if ((number1 > 0) && (number2 < 0) && (number3 > 0))
        {
            Console.WriteLine("-");
        }
        else if ((number1 > 0) && (number2 > 0) && (number3 < 0))
        {
            Console.WriteLine("-");
        }
        else if ((number1 < 0) && (number2 < 0) && (number3 < 0))
        {
            Console.WriteLine("-");
        }
        else if ((number1 == 0) || (number2 == 0) || (number3 == 0))
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}

