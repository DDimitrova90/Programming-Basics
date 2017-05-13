using System;

class ChessboardGame   //https://judge.softuni.bg/Contests/Practice/Index/81#1
{                      
    static void Main()   
    {
        int n = int.Parse(Console.ReadLine());
        string inputStr = Console.ReadLine();
        int blackTeam = 0;
        int whiteTeam = 0;

        for (int i = 0; i < inputStr.Length; i++)
        {
            if (i >= n * n)
            {
                break;
            }
           
            if (i % 2 == 0 && char.IsUpper(inputStr[i]))
            {
                whiteTeam += inputStr[i];
            }
            else if (i % 2 == 0 && char.IsLetterOrDigit(inputStr[i]))
            {
                blackTeam += inputStr[i];
            }
            else if (i % 2 != 0 && char.IsUpper(inputStr[i]))
            {
                blackTeam += inputStr[i];
            }
            else if (i % 2 != 0 && char.IsLetterOrDigit(inputStr[i]))
            {
                whiteTeam += inputStr[i];
            }
        }

        if (whiteTeam == blackTeam)
        {
            Console.WriteLine("Equal result: {0}", whiteTeam);
        }
        else
        {
            Console.WriteLine("The winner is: {0} team", whiteTeam > blackTeam ? "white" : "black");
            Console.WriteLine(Math.Abs(whiteTeam - blackTeam));
        }
    }
}

