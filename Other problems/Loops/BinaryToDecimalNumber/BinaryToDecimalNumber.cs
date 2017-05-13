using System;
using System.Numerics;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary integer number: ");
        string number = Console.ReadLine();

        BigInteger NumInBinary = BigInteger.Parse(number);    
        BigInteger NumInDecimal = 0;
        BigInteger lastBitValue = 0;       
        
        for (int i = 0; i < number.Length; i++)
        {
            lastBitValue = NumInBinary % 10;  //take the digit from the last position
            NumInBinary /= 10;                //remove the digit from the last position
            NumInDecimal += lastBitValue * (int)Math.Pow(2, i);                                  
        }

        Console.WriteLine(NumInDecimal);
    }
}

