using System;

class OddEvenElements    // https://judge.softuni.bg/Contests/Practice/Index/7#1
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        } 

        string[] numbers = input.Split(' ');

        double oddSum = 0;
        double evenSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        double currOdd = 0;
        double currEven = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddSum += double.Parse(numbers[i]);
                currOdd = double.Parse(numbers[i]);

                if (currOdd < oddMin)
                {
                    oddMin = currOdd;
                } 

                if (currOdd > oddMax)
                {
                    oddMax = currOdd;
                }     
            }
            else
            {
                evenSum += double.Parse(numbers[i]);
                currEven = double.Parse(numbers[i]);

                if (currEven < evenMin)
                {
                    evenMin = currEven;
                }

                if (currEven > evenMax)
                {
                    evenMax = currEven;
                }
            }
        }

        if (numbers.Length - 1 == 0)
        {
            Console.WriteLine(
                "OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", 
                oddSum, oddMin, oddMax);
        }
        else
        {
            Console.WriteLine(
                "OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}", 
                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}

