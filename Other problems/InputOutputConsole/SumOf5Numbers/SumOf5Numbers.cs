using System;

class SumOf5Numbers
{
    static void Main()
    {
        string singleLine = Console.ReadLine();
        string[] values = singleLine.Split(' ');
        int number1 = int.Parse(values[0]);
        int number2 = int.Parse(values[1]);
        int number3 = int.Parse(values[2]);
        int number4 = int.Parse(values[3]);
        int number5 = int.Parse(values[4]);
    }
}

