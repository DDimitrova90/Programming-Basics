using System;

class RectangleWithStars  // https://judge.softuni.bg/Contests/Practice/Index/157#9
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rowNum = n - 1;  

        if (n % 2 == 1) rowNum++;   

        Console.WriteLine(new string('%', 2 * n));

        for (int row = 0; row < rowNum; row++)
        {
            Console.Write("%");
            Console.Write(new string(' ', n - 2));          

            if (row == ((n - 1) / 2))  
            {
                Console.Write("**");
            }
            else
            {
                Console.Write("  ");
            }

            Console.Write(new string(' ', n - 2));
            Console.WriteLine("%");
        }
        Console.WriteLine(new string('%', 2 * n));
    }
}

