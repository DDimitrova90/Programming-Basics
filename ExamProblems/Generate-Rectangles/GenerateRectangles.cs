using System;

class GenerateRectangles   // https://judge.softuni.bg/Contests/Practice/Index/157#11
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        bool printNo = true;      

        for (int left = - n; left <= n; left++)
        {
            for (int right = left + 1; right <= n; right++)
            {
                for (int top = - n; top <= n; top++)
                {
                    for (int bottom = top + 1; bottom <= n; bottom++)
                    {
                        if ((left < right) && (top < bottom))
                        {
                            int sideA = Math.Abs(right - left);
                            int sideB = Math.Abs(bottom - top);
                            int area = sideA * sideB;

                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}"
                                    , left, top, right, bottom, area);
                                printNo = false;
                            }
                        }
                    }
                }
            }
        }

        if (printNo)
        {
            Console.WriteLine("No");
        }
    }
}

