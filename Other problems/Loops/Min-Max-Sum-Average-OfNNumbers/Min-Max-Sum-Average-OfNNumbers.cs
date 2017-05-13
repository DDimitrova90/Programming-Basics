using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        float avg;
        int min = int.MaxValue;
        int max = int.MinValue;
                        
        for (int i = 0; i < num; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }

        avg = (float)sum / num;

        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}

