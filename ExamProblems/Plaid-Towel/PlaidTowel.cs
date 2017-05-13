using System;

class PlaidTowel     // https://judge.softuni.bg/Contests/Practice/Index/119#2
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char back = char.Parse(Console.ReadLine());
        char rhomb = char.Parse(Console.ReadLine());

        Console.WriteLine(
            new string(back, size) + 
            rhomb + 
            new string(back, 2 * size - 1) + 
            rhomb + 
            new string(back, size));

        for (int j = 0; j < 2; j++)
        {
            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine(
                    new string(back, size - 1 - i) +
                    rhomb +
                    new string(back, (2 * i) + 1) +
                    rhomb +
                    new string(back, (2 * size) - 3 - (2 * i)) +
                    rhomb +
                    new string(back, (2 * i) + 1) +
                    rhomb +
                    new string(back, size - 1 - i));
            }

            Console.WriteLine(
                rhomb +
                new string(back, (2 * size) - 1) +
                rhomb +
                new string(back, (2 * size) - 1) +
                rhomb);

            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine(
                    new string(back, i + 1) +
                    rhomb +
                    new string(back, (2 * size) - 3 - (2 * i)) +
                    rhomb +
                    new string(back, (2 * i) + 1) +
                    rhomb +
                    new string(back, (2 * size) - 3 - (2 * i)) +
                    rhomb +
                    new string(back, i + 1));
            }

            Console.WriteLine(
                new string(back, size) +
                rhomb +
                new string(back, (2 * size) - 1) +
                rhomb +
                new string(back, size));
        }       
    }
}

