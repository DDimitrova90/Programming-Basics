using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime newDays = birthDate.AddDays(999);

        Console.WriteLine("{0:dd-MM-yyyy}", newDays);       
    }
}

