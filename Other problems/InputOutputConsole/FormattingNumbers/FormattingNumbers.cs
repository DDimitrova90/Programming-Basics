using System;
class FormattingNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        string binary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:F3}|", firstNumber, binary, secondNumber, thirdNumber);
    }
}

