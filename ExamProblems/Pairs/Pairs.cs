using System;

class Pairs     // https://judge.softuni.bg/Contests/Practice/Index/6#1
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] number = input.Split(' ');
        int firstNum = int.Parse(number[0]);
        int secondNum = int.Parse(number[1]);
        int currValue = firstNum + secondNum;
        int maxDiff = 0;

        for (int i = 2; i <= number.Length - 1; i+=2)
        {
            firstNum = int.Parse(number[i]);
            secondNum = int.Parse(number[i + 1]);
            int nextValue = firstNum + secondNum;
            int diff = Math.Abs(nextValue - currValue);
            maxDiff = Math.Max(diff, maxDiff);
            currValue = nextValue;
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", currValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}

