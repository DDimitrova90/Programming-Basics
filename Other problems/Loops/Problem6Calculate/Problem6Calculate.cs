using System;

class Problem6Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        decimal resultDevision = 1;

        //  7!/5! = 7*6 or n!/k! = n!, we multiply it with the result from n-k
        for (int i = n; i > k; i--)      
        {
            resultDevision *= i;
        }

        Console.WriteLine(resultDevision);
    }
}

