using System;
using System.Numerics;

class Problem7Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialNK = 1;
        BigInteger factorialNMinusK = 1;
        int nMinusK = n - k;

        for (int i = n; i > k; i--)     //this is n!/k! and we have to find (n-k)!
        {
            factorialNK *= i;
        }
        for (int j = 1; j <= nMinusK; j++)   //this is (n-k)!
        {
            factorialNMinusK *= j;
        }

        BigInteger result = factorialNK / factorialNMinusK;
        Console.WriteLine(result);
    }
}

