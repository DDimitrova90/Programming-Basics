using System;

class RandomNumbersInGivenRange
{
    static void Main()              //http://www.dotnetperls.com/random
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random randomNum = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomNum.Next(min, max + 1) + " ");  
            //max + 1 because we want and the last element
        }

        Console.WriteLine();       
    }
}

