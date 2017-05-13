using System;

class TheFootballStatistician   // https://judge.softuni.bg/Contests/Practice/Index/104#1
{
    static void Main()
    {
        decimal paymentPerMatch = decimal.Parse(Console.ReadLine());
        string matchResult = Console.ReadLine();

        int matches = 0;
        int team1Points = 0;
        int team2Points = 0;
        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int liverpoolPoints = 0;
        int evertonPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;

        while (matchResult != "End of the league.")
        {
            string[] parameters = matchResult
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string team1 = parameters[0];
            string outcome = parameters[1];
            string team2 = parameters[2];

            team1Points = 0;
            team2Points = 0;
            matches++;
            
            if (outcome == "X")
            {
                team1Points += 1;
                team2Points += 1;
            }
            else if (outcome == "1")
            {
                team1Points += 3;
            }
            else if (outcome == "2")
            {
                team2Points += 3;
            }

            switch (team1)
            {
                case "Arsenal":
                    arsenalPoints += team1Points;
                    break;
                case "Chelsea":
                    chelseaPoints += team1Points;
                    break;
                case "ManchesterCity":
                    manchesterCityPoints += team1Points;
                    break;
                case "ManchesterUnited":
                    manchesterUnitedPoints += team1Points;
                    break;
                case "Liverpool":
                    liverpoolPoints += team1Points;
                    break;
                case "Everton":
                    evertonPoints += team1Points;
                    break;
                case "Southampton":
                    southamptonPoints += team1Points;
                    break;
                case "Tottenham":
                    tottenhamPoints += team1Points;
                    break;
            }

            switch (team2)
            {
                case "Arsenal":
                    arsenalPoints += team2Points;
                    break;
                case "Chelsea":
                    chelseaPoints += team2Points;
                    break;
                case "ManchesterCity":
                    manchesterCityPoints += team2Points;
                    break;
                case "ManchesterUnited":
                    manchesterUnitedPoints += team2Points;
                    break;
                case "Liverpool":
                    liverpoolPoints += team2Points;
                    break;
                case "Everton":
                    evertonPoints += team2Points;
                    break;
                case "Southampton":
                    southamptonPoints += team2Points;
                    break;
                case "Tottenham":
                    tottenhamPoints += team2Points;
                    break;
            }

            matchResult = Console.ReadLine();
        }

        decimal profit = matches * paymentPerMatch * 1.94M;

        Console.WriteLine("{0:F2}lv.", profit);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
    }
}

