using System;
using System.Numerics;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter your decimal number: ");
        BigInteger numInDecimal = BigInteger.Parse(Console.ReadLine());

        string numInBinary = string.Empty;

        if (numInDecimal == 0)
        {
            numInBinary = "0";
        }
        else
        {
            while (numInDecimal > 0)
            {
                int remain = (int)numInDecimal % 2;
                numInDecimal /= 2;
                numInBinary = remain + numInBinary; 
            }
        }

        Console.WriteLine(numInBinary);
    }
}

