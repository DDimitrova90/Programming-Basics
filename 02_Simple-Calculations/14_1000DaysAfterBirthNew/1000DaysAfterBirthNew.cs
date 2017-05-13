using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.ParseExact(input, "dd-MM-yyyy", null);

        Console.WriteLine(birthDate.AddDays(999).ToString("dd-MM-yyyy"));
    }
}
