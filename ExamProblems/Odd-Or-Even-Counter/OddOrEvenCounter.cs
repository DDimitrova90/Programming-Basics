using System;

class OddOrEvenCounter     // https://judge.softuni.bg/Contests/Practice/Index/37#1
{
    static void Main()
    {
        int countOfSets = int.Parse(Console.ReadLine());
        int numsInSet = int.Parse(Console.ReadLine());
        string typeToCount = Console.ReadLine();

        int numsToCount = 0;
        int biggestCount = 0;
        int set = 0;
        string setOrdinal = string.Empty;

        for (int i = 1; i <= countOfSets; i++)
        {
            numsToCount = 0;

            for (int j = 1; j <= numsInSet; j++)
            {
                int num = int.Parse(Console.ReadLine());
                if (typeToCount == "even" && num % 2 == 0)
                {
                    numsToCount++;
                }
                else if (typeToCount == "odd" && num % 2 != 0)
                {
                    numsToCount++;
                }
            }

            if (numsToCount > biggestCount)
            {
                biggestCount = numsToCount;
                set = i;
            }        
        }

        switch (set)
        {
            case 1: setOrdinal = "First"; break;
            case 2: setOrdinal = "Second"; break;
            case 3: setOrdinal = "Third"; break;
            case 4: setOrdinal = "Fourth"; break;
            case 5: setOrdinal = "Fifth"; break;
            case 6: setOrdinal = "Sixth"; break;
            case 7: setOrdinal = "Seventh"; break;
            case 8: setOrdinal = "Eigth"; break;
            case 9: setOrdinal = "Ninth"; break;
            case 10: setOrdinal = "Tenth"; break;
        }

        if (numsToCount > 0)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", 
                setOrdinal, typeToCount, biggestCount);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

