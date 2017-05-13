using System;

class SumOfElements    // https://judge.softuni.bg/Contests/Practice/Index/4#1
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        long sum = 0;
        long currNum = 0;
        long maxNum = long.MinValue;

        for (long i = 0; i < numbers.Length; i++)
        {
            sum += long.Parse(numbers[i]);
            currNum = long.Parse(numbers[i]);

            if (currNum > maxNum)
            {
                maxNum = currNum;
            }
        }

        if ((sum - maxNum) == maxNum)
        {
            Console.WriteLine("Yes, sum={0}", maxNum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(maxNum - (sum - maxNum)));
        }
    }
}

