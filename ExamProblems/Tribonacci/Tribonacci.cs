using System;
using System.Numerics;

class Tribonacci       // https://judge.softuni.bg/Contests/Practice/Index/1#1
{
    static void Main()
    {
        BigInteger firstElement = BigInteger.Parse(Console.ReadLine());
        BigInteger secondElement = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdElement = BigInteger.Parse(Console.ReadLine());
        int nElement = int.Parse(Console.ReadLine());

        if (nElement == 1)
        {
            Console.WriteLine(firstElement);
        }
        else if (nElement == 2)
        {
            Console.WriteLine(secondElement);
        }
        else if (nElement == 3)
        {
            Console.WriteLine(thirdElement);
        }
        else
        {
            for (int i = 0; i < nElement - 3; i++)
            {

                BigInteger currElement = firstElement + secondElement + thirdElement;

                if (i == nElement - 4)
                {
                    Console.WriteLine(currElement);
                }

                firstElement = secondElement;
                secondElement = thirdElement;
                thirdElement = currElement;
                currElement = 0;
            }
        }      
    }
}

