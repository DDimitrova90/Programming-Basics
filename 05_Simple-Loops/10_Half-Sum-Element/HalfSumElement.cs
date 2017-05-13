using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxElement = 0;
        int sum = 0;

        int num = int.Parse(Console.ReadLine());
        sum += num;
        maxElement = num;

        for (int i = 0; i < n - 1; i++)
        {
            num = int.Parse(Console.ReadLine());            
            sum += num;
            
            if (num > maxElement)
            {
                maxElement = num;
            }          
        }

        int halfSum = sum - maxElement;

        if (halfSum == maxElement)
        {
            Console.WriteLine("Yes\nSum = {0}", maxElement);
        }
        else
        {
            Console.WriteLine("No\nDiff = {0}", Math.Abs(halfSum - maxElement));
        }      
    }
}

