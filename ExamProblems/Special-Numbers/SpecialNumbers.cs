using System;
using System.Collections.Generic;

class SpecialNumbers               
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        List<int> dividors = new List<int>();

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {         
                dividors.Add(i);
            }           
        }      
    }
}

