using System;

class BiggestTriple    // https://judge.softuni.bg/Contests/Practice/Index/8#1
{                      
    static void Main()
    {
        string input = Console.ReadLine();
        input = input + " " + 2000;
        string[] numbers = input.Split(' ');

        int sum = 0;
        int biggestSum = 0;
        int triple = 0;

        for (int i = 0; i < numbers.Length - 1; i += 3)
        {
            if (i < numbers.Length)
            {
                if (i + 2 > numbers.Length - 1)
                {
                    sum += int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
                }
                else if (i + 1 > numbers.Length - 1)
                {
                    sum += int.Parse(numbers[i]);
                }
                else
                {
                    sum += int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) + int.Parse(numbers[i + 2]);
                }

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    triple = i;
                }

                sum = 0;
            }
        }

        int counter = triple;

        while ((counter < (triple + 3)) && (counter < numbers.Length - 1))
        {
            Console.Write(numbers[counter] + " ");
            counter++;
        }
    }
}

