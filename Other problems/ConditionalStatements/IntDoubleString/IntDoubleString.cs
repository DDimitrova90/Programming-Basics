using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int type = int.Parse(Console.ReadLine());
        
        switch (type)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine(word + "*");
                break;
            default:
                Console.WriteLine("Not correct choice!");
                break;
        }
    }
}

