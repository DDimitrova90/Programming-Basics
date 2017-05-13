using System;

class StripedTowel    // https://judge.softuni.bg/Contests/Practice/Index/104#2
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        double height = Math.Floor(width * 1.5d);     

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                bool isStripe = (i + j) % 3 == 0;
                if (isStripe)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}
