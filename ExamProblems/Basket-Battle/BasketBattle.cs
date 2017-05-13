using System;

class BasketBattle      // https://judge.softuni.bg/Contests/Practice/Index/78#1
{
    static void Main()
    {
        string playerStart = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());
        int scoresPlayer1 = 0;
        int scoresPlayer2 = 0;
        int winRound = 0;

        for (int i = 0; i < rounds; i++)
        {
            int firstPoints = int.Parse(Console.ReadLine());
            string firstResult = Console.ReadLine();

            if (i % 2 == 0 && firstResult == "success" && scoresPlayer1 + firstPoints <= 500)
            {
                scoresPlayer1 += firstPoints;
            }
            if (i % 2 != 0 && firstResult == "success" && scoresPlayer2 + firstPoints <= 500)
            {
                scoresPlayer2 += firstPoints;
            }
            if (scoresPlayer1 == 500 || scoresPlayer2 == 500)
            {
                winRound = i + 1;
                break;
            }


            int secondPoints = int.Parse(Console.ReadLine());
            string secondResult = Console.ReadLine();
 
            if (i % 2 == 0 && secondResult == "success" && scoresPlayer2 + secondPoints <= 500)
            {
                scoresPlayer2 += secondPoints;
            }
            
            if (i % 2 != 0 && secondResult == "success" && scoresPlayer1 + secondPoints <= 500)
            {
                scoresPlayer1 += secondPoints;
            }
            if (scoresPlayer1 == 500 || scoresPlayer2 == 500)
            {
                winRound = i + 1;
                break;
            }          
        }

        if (scoresPlayer1 == 500)
        {
            Console.WriteLine(playerStart == "Nakov" ? "Nakov" : "Simeon");
            Console.WriteLine(winRound);
            Console.WriteLine(scoresPlayer2);
        }
        else if (scoresPlayer2 == 500)
        {
            Console.WriteLine(playerStart == "Nakov" ? "Simeon" : "Nakov");
            Console.WriteLine(winRound);
            Console.WriteLine(scoresPlayer1);
        }
        else if (scoresPlayer1 == scoresPlayer2)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(scoresPlayer1);
        }
        else
        {
            if (scoresPlayer1 > scoresPlayer2)
            {
                Console.WriteLine(playerStart == "Nakov" ? "Nakov" : "Simeon");
            }
            else
            {
                Console.WriteLine(playerStart == "Nakov" ? "Simeon" : "Nakov");
            }

            Console.WriteLine(Math.Abs(scoresPlayer1 - scoresPlayer2));
        }
    }
}

