using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int first = 1;
        int second = 1;
        int newNum = 0; ;

        if (n < 2)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                newNum = first + second;
                first = second;
                second = newNum;
            }

            Console.WriteLine(newNum);
        }
    }
}

