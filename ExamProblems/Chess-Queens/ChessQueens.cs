using System;

class ChessQueens     // https://judge.softuni.bg/Contests/Practice/Index/23#3
{                      
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int diff = distance + 1;
        char[] letters = new char[n];
        bool isNotValid = true;

        for (int i = 0; i < n; i++)
        {
            letters[i] = (char)('a' + i);
        }

        for (int x1 = 0; x1 < n; x1++)
        {
            for (int y1 = 0; y1 < n; y1++)
            {
                for (int x2 = 0; x2 < n; x2++)
                {
                    for (int y2 = 0; y2 < n; y2++)
                    {
                        bool xMeet = y1 == y2 && Math.Abs(x2 - x1) == diff;
                        bool yMeet = x1 == x2 && Math.Abs(y2 - y1) == diff;
                        bool diagonal = Math.Abs(x2 - x1) == diff && Math.Abs(y2 - y1) == diff;

                        if (xMeet || yMeet || diagonal)
                        {
                            Console.WriteLine("{0}{1} - {2}{3}", letters[x1], y1 + 1, letters[x2], y2 + 1);
                            isNotValid = false;
                        }
                    }
                }
            }
        }

        if (isNotValid)
        {
            Console.WriteLine("No valid positions");
        }
    }
}

