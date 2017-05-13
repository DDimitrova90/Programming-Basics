using System;

class SequenceOfKNumbers    // https://judge.softuni.bg/Contests/Practice/Index/10#1
{
    static void Main()
    {
        string input = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());

        // To check the last number from the sequence we add one additional number.
        input = input + " " + 2000; 
        string[] inputString = input.Split(' ');    
        int prevNum = int.Parse(inputString[0]);
        int countEquals = 1;

        for (int i = 1; i < inputString.Length; i++)
        {
            int currNum = int.Parse(inputString[i]);

            if (currNum == prevNum)
            {
                countEquals += 1;   
            }
            else
            {
                for (int j = 0; j < countEquals % k; j++)
                {
                    Console.Write(prevNum + " ");
                }

                countEquals = 1;
            }

            prevNum = currNum;
        }
    }
}

