using System;

class Firefighters              // https://judge.softuni.bg/Contests/Practice/Index/119#3
{
    static void Main()
    {
        int initialFirefighters = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int totalSavedKids = 0;
        int totalSavedAdults = 0;
        int totalSavedSeniors = 0;

        while (command != "rain")
        {
            int firefighters = initialFirefighters;
            int kids = 0;
            int adults = 0;
            int seniors = 0;

            foreach (char letter in command)   
            {
                switch (letter)
                {
                    case 'K':
                        kids++;
                        break;
                    case 'A':
                        adults++;
                        break;
                    case 'S':
                        seniors++;
                        break;
                }
            }

            if (firefighters - kids >= 0)
            {
                totalSavedKids += kids;
                firefighters -= kids;
            }
            else
            {
                totalSavedKids += firefighters;
                firefighters = 0;
            }

            if (firefighters - adults >= 0)
            {
                totalSavedAdults += adults;
                firefighters -= adults;
            }
            else
            {
                totalSavedAdults += firefighters;
                firefighters = 0;
            }

            if (firefighters - seniors >= 0)
            {
                totalSavedSeniors += seniors;
                firefighters -= seniors;
            }
            else
            {
                totalSavedSeniors += firefighters;
                firefighters = 0;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine("Kids: {0}", totalSavedKids);
        Console.WriteLine("Adults: {0}", totalSavedAdults);
        Console.WriteLine("Seniors: {0}", totalSavedSeniors);        
    }
}

