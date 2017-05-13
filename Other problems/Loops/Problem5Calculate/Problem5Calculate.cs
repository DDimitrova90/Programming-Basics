using System;

class Problem5Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        decimal factorialN = 1;
        decimal numXPowerN = 1;
        decimal sumOfSequence = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            numXPowerN *= x;
            sumOfSequence += (factorialN / numXPowerN);
        }

        Console.WriteLine("{0:F5}", sumOfSequence);
    }    
}

