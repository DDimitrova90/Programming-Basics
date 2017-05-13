using System;

class EncodedAnswers   // https://judge.softuni.bg/Contests/Practice/Index/163#1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int answerA = 0;
        int answerB = 0;
        int answerC = 0;
        int answerD = 0;
        string answer = null;
        string result = null;

        for (int i = 0; i < n; i++)
        {
            uint num = uint.Parse(Console.ReadLine());

            if (num % 4 == 0)
            {
                answer = "a";
                answerA++;
            }
            else if (num % 4 == 1)
            {
                answer = "b";
                answerB += 1;
            }
            else if (num % 4 == 2)
            {
                answer = "c";
                answerC++;
            }
            else if (num % 4 == 3)
            {
                answer = "d";
                answerD++;
            }

            result += answer + " ";
        }

        Console.WriteLine(result);
        Console.WriteLine("Answer A: " + answerA);
        Console.WriteLine("Answer B: " + answerB);
        Console.WriteLine("Answer C: " + answerC);
        Console.WriteLine("Answer D: " + answerD);
    }
}

