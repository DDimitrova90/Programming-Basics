using System;

class NumberInRange1To100
{
    static void Main()
    {
        Console.Write("Еnter a number in the range [1...100]: ");
        int n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number!");
            Console.Write("Еnter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
        }

        if (n >= 1 && n <= 100)
        {
            Console.WriteLine("The number is: " + n);
        }
    }
}

