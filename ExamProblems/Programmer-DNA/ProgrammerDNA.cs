using System;
  
class ProgrammerDNA      // https://judge.softuni.bg/Contests/Practice/Index/9#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char firstLetter = char.Parse(Console.ReadLine());
        int counter = 0;

        while (counter <= n)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(new string('.', 3 - j));

                for (int k = 0; k < 1 + (2 * j); k++)
                {
                    Console.Write(firstLetter);

                    if (firstLetter == 'G')
                    {
                        firstLetter = 'A';
                    }
                    else
                    {
                        firstLetter++;
                    }
                }

                Console.WriteLine(new string('.', 3 - j));

                counter++;

                if (counter == n)
                {
                    return;
                }
            }

            for (int l = 0; l < 3; l++)
            {
                Console.Write(new string('.', 1 + l));

                for (int m = 0; m < 5 - (2 * l); m++)
                {
                    Console.Write(firstLetter);

                    if (firstLetter == 'G')
                    {
                        firstLetter = 'A';
                    }
                    else
                    {
                        firstLetter++;
                    }
                }

                Console.WriteLine(new string('.', 1 + l));

                counter++;

                if (counter == n)
                {
                    return;
                }
            }
        }
    }
}

