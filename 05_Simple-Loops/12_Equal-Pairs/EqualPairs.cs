using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int prevSum = 0;
        int currentSum = 0;
        int diff = 0;
        int maxDiff = 0;

        for (int i = 0; i < n; i++)
        {
            prevSum = currentSum;
            currentSum = 0;

            currentSum += int.Parse(Console.ReadLine());
            currentSum += int.Parse(Console.ReadLine());

            if (i != 0)
            {
                diff = Math.Abs(prevSum - currentSum);
            }
            if (diff != 0 && diff > maxDiff)
            {
                maxDiff = diff;
            }
        }

        if (n == 1 || diff == 0)
        {
            Console.WriteLine("Yes, value={0}", currentSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}


