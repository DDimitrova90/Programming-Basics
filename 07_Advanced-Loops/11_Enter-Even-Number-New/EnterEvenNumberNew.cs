using System;

class EnterEvenNumberNew
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter even number: ");
            string input = Console.ReadLine();
            int number = 0;

            try
            {
                number = int.Parse(input);

                if (number % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                }
                else
                {
                    Console.WriteLine("Even number entered: " + number);
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
        }       
    }
}

