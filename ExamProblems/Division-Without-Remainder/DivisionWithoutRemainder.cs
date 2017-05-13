using System;

class DivisionWithoutRemainder
{
    static void Main()
    {
        int numOfNums = int.Parse(Console.ReadLine());
        double divisibleBy2 = 0;
        double divisibleBy3 = 0;
        double divisibleBy4 = 0;

        for (int i = 0; i < numOfNums; i++)
        {
            int number = int.Parse(Console.ReadLine());

            // all must be IF because some of the numbers can be 
            // devided by 2, 3 and 4 without remainder in the same time
            if (number % 2 == 0)    
            {                      
                divisibleBy2++;
            }
            if (number % 3 == 0)
            {
                divisibleBy3++;
            }
            if (number % 4 == 0)
            {
                divisibleBy4++;
            }
        }

        double resultBy2 = (divisibleBy2 / numOfNums) * 100; 
        double resultBy3 = (divisibleBy3 / numOfNums) * 100; 
        double resultBy4 = (divisibleBy4 / numOfNums) * 100;

        Console.WriteLine("{0:F2}%", resultBy2);
        Console.WriteLine("{0:F2}%", resultBy3);
        Console.WriteLine("{0:F2}%", resultBy4);
    }
}

