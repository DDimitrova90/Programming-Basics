using System;

class LocalElections   // https://judge.softuni.bg/Contests/Practice/Index/129#2
{
    static void Main()
    {
        int candidates = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine().ToUpper();

        string dots = new string('.', 13);     

        Console.WriteLine(dots);
        
        for (int i = 1; i <= candidates; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j % 4 == 0)
                {
                    Console.WriteLine("...+-----+...");
                }
                else
                {
                    if (symbol == "X" && vote == i)
                    {
                        if (j == 1)
                        {
                            Console.WriteLine("...|.\\./.|...");
                        }
                        else if (j == 2)
                        {
                            Console.WriteLine("{0:00}.|..X..|...", i);
                        }
                        else if (j == 3)
                        {
                            Console.WriteLine("...|./.\\.|...");
                        }
                    }
                    else if (symbol == "V" && vote == i)
                    {
                        if (j == 1)
                        {
                            Console.WriteLine("...|\\.../|...");
                        }
                        else if (j == 2)
                        {
                            Console.WriteLine("{0:00}.|.\\./.|...", i);
                        }
                        else if (j == 3)
                        {
                            Console.WriteLine("...|..V..|...");
                        }
                    }
                    else
                    {
                        if (j == 2)
                        {
                            Console.WriteLine("{0:00}.|.....|...", i);
                        }
                        else
                        {
                            Console.WriteLine("...|.....|...");
                        }                       
                    }                   
                }              
            }

            Console.WriteLine(dots);
        }     
    }
}

