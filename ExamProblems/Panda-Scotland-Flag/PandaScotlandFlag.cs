using System;

class PandaScotlandFlag    // https://judge.softuni.bg/Contests/Practice/Index/17#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char firstChar = 'A';
        char secondChar;

        for (int i = 0; i < (n - 1) / 2; i++)
        { 
            if (firstChar > 89)
            {
                firstChar = 'A';
            }

            secondChar = (char)(firstChar + 1);

            Console.WriteLine(
                new string('~', i) + firstChar + 
                new string('#', n - 2 - (2 * i)) + secondChar + 
                new string('~', i));

            firstChar = (char)(firstChar + 2);
        }

        Console.WriteLine(
            new string('-', (n - 1) / 2) + firstChar + 
            new string('-', (n - 1) / 2));

        firstChar = (char)(firstChar + 1);
        
        for (int i = 0; i < (n - 1) / 2; i++)
        {         
            if (firstChar > 90)
            {
                firstChar = (char)(66);
            }

            secondChar = (char)(firstChar + 1);

            if (secondChar > (char)89)
            {
                secondChar = (char)65;
            }       

            Console.WriteLine(
                new string('~', ((n - 3) / 2) - i) + firstChar + 
                new string('#', 1 + (2 * i)) + secondChar + 
                new string('~', ((n - 3) / 2) - i));

            firstChar = (char)(firstChar + 2);          
        }
    }
}

