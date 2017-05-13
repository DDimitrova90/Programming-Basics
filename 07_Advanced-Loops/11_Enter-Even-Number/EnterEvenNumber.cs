using System;

class EnterEvenNumber
{
    static void Main()
    {
        Console.Write("Enter even number: ");
        string input = Console.ReadLine();
        int number = 0;
        bool result = int.TryParse(input, out number);

        while (result == false || number % 2 != 0)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            Console.Write("Enter even number: ");
            input = Console.ReadLine();
            result = int.TryParse(input, out number);
        }

        Console.WriteLine("Even number entered: " + number);
    }
}

