﻿using System;

class InchesToCentimeters
{
    static void Main()
    {
        Console.Write("inches = ");

        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;
        
        Console.Write("Centimeters = ");
        Console.WriteLine(centimeters);
    }
}

