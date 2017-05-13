using System;

class SpecialNumbersNew
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int a = 1; a < 10; a++)
        {
            for (int b = 1; b < 10; b++)
            {
                for (int c = 1; c < 10; c++)
                {
                    for (int d = 1; d < 10; d++)
                    {
                        if ((num % a == 0) && (num % b == 0) && (num % c == 0) && (num % d == 0))
                        {
                            Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                        }                    
                    }
                }
            }
        }
    }
}

