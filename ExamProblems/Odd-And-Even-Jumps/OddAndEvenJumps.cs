using System;

class OddAndEvenJumps    // https://judge.softuni.bg/Contests/Practice/Index/18#1
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        ulong oddResult = 0;
        ulong evenResult = 0;
        int oddCounter = 0;
        int evenCounter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddCounter++;

                if (oddCounter % oddJump != 0)
                {
                    oddResult += input[i];
                }
                else
                {
                    oddResult *= input[i];
                }
            }
            else
            {
                evenCounter++;

                if (evenCounter % evenJump != 0)
                {
                    evenResult += input[i];
                }
                else
                {
                    evenResult *= input[i];
                }
            }
        }

        string oddHex = oddResult.ToString("X");   //we make the number in hexadecimal numeric system
        string evenHex = evenResult.ToString("X");

        Console.WriteLine("Odd: " + oddHex);
        Console.WriteLine("Even: " + evenHex);
    }
}

