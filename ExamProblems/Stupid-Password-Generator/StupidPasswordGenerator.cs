using System;

class StupidPasswordGenerator   //https://judge.softuni.bg/Contests/Practice/Index/169#5 06.03.2016
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i1 = 1; i1 <= n; i1++)
        {
            for (int i2 = 1; i2 <= n; i2++)
            {
               for (int i3 = 97; i3 < 97 + l; i3++)
                {
                    for (int i4 = 97; i4 < 97 + l; i4++)
                    {
                        for (int i5 = 1; i5 <= n; i5++)
                        {
                            if ((i5 > i1) && (i5 > i2))
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i1, i2, (char)i3, (char)i4, i5);
                            } 
                        }
                    }
                }
            }
        }
    }
}

