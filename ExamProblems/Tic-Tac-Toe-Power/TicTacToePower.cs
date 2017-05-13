using System;

class TicTacToePower    // https://judge.softuni.bg/Contests/Practice/Index/24#0
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int firstValue = 0;
        value = value - 1;
        int index = 0;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                index++;
                value++;
                firstValue = value;

                if (x == col && y == row)
                {
                    Console.WriteLine((long)Math.Pow(firstValue, index));
                    break;
                }
            }
        }
    }
}

