using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", number, factorial);
    }
}

