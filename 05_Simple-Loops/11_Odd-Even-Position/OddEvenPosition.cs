using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double evenSum = 0;
        double oddSum = 0;
        double oddMin = 0;
        double oddMax = 0;
        double evenMin = 0;
        double evenMax = 0;

        if (n == 0)
        {
            Console.WriteLine("OddSum=0\nOddMin=No\nOddMax=No\nEvenSum=0\nEvenMin=No\nEvenMax=No");       
        }
        else if (n == 1)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("OddSum={0}\nOddMin={0}\nOddMax={0}\nEvenSum=0\nEvenMin=No\nEvenMax=No", num);
        }
        else
        {
            double num = double.Parse(Console.ReadLine());
            oddSum += num;
            oddMin = num;
            oddMax = num;

            num = double.Parse(Console.ReadLine());
            evenSum += num;
            evenMin = num;
            evenMax = num;

            for (int i = 1; i <= n - 2; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    else if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    else if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }

            Console.WriteLine("OddSum={0}\nOddMin={1}\nOddMax={2}\nEvenSum={3}\nEvenMin={4}\nEvenMax={5}",
                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }       
    }
}

