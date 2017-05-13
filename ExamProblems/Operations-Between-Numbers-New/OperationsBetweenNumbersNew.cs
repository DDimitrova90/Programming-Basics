using System;

class OperationsBetweenNumbersNew
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        string oper = Console.ReadLine();

        double result = 0;

        if (oper == "+")
        {
            result = num1 + num2;
            Console.Write($"{num1} + {num2} = {result} - ");
            Console.WriteLine(result % 2 == 0 ? "even" : "odd");
        }
        else if (oper == "-")
        {
            result = num1 - num2;
            Console.Write($"{num1} - {num2} = {result} - ");
            Console.WriteLine(result % 2 == 0 ? "even" : "odd");
        }
        else if (oper == "*")
        {
            result = num1 * num2;
            Console.Write($"{num1} * {num2} = {result} - ");
            Console.WriteLine(result % 2 == 0 ? "even" : "odd");
        }
        else if (oper == "/")
        {
            result = (double)num1 / num2;    
            Console.WriteLine(num2 == 0
                ? $"Cannot divide {num1} by zero"
                : $"{num1} / {num2} = {result:F2}");
        }
        else if (oper == "%")
        {
            result = (double)num1 % num2;
            Console.WriteLine(num2 == 0
                ? $"Cannot divide {num1} by zero"
                : $"{num1} % {num2} = {result}");
        }
    }
}

