using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialTwoN = 1;
        BigInteger factorialNOne = 1;
        BigInteger factorialN = 1;

        for (int i = 1; i <= (2 * n); i++)
        {
            factorialTwoN *= i;
        }
        for (int j = 1; j <= (n +1); j++)
        {
            factorialNOne *= j;
        }
        for (int k = 1; k <= n; k++)
        {
            factorialN *= k;
        }

        BigInteger result = factorialTwoN / (factorialNOne * factorialN);
        Console.WriteLine(result);
    }
}

