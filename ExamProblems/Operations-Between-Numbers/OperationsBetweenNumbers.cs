using System;

class OperationsBetweenNumbers      //https://judge.softuni.bg/Contests/Practice/Index/181#2
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        char operatorCh = char.Parse(Console.ReadLine());
        double result = 0;

        if (operatorCh == '+')
        {
            result = firstNumber + secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", 
                    firstNumber, operatorCh, secondNumber, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", 
                    firstNumber, operatorCh, secondNumber, result);
            }
        }

        if (operatorCh == '-')
        {
            result = firstNumber - secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", 
                    firstNumber, operatorCh, secondNumber, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", 
                    firstNumber, operatorCh, secondNumber, result);
            }
        }

        if (operatorCh == '*')
        {
            result = firstNumber * secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", 
                    firstNumber, operatorCh, secondNumber, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", 
                    firstNumber, operatorCh, secondNumber, result);
            }
        }

        if (operatorCh == '/')
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }
            else
            {
                result = firstNumber / (double)secondNumber;
                Console.WriteLine("{0} / {1} = {2:F2}", firstNumber, secondNumber, result);
            }
        }

        if (operatorCh == '%')
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }
            else
            {
                result = firstNumber % secondNumber;
                Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, result);
            }           
        }
    }
}

