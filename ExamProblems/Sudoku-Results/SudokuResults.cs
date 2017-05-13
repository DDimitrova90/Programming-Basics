using System;

class SudokuResults    // https://judge.softuni.bg/Contests/Practice/Index/129#1
{
    static void Main()
    {
        string gameResult = Console.ReadLine();

        int games = 0;
        int time = 0;

        while (gameResult != "Quit")
        {
            string[] parameters = gameResult.Split(':');
            int mm = int.Parse(parameters[0]);
            int ss = int.Parse(parameters[1]);

            time += (mm * 60) + ss;
            games++;
           
            gameResult = Console.ReadLine();        
        }

        double averageSec = (double)time / games; 

        if (averageSec < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (averageSec >= 720 && averageSec <= 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else
        {
            Console.WriteLine("Bronze Star");
        }

        Console.WriteLine("Games - {0} \\ Average seconds - {1}", games, Math.Ceiling(averageSec));
    }
}

