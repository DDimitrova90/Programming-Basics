using System;

class Numbers0100ToText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string[] zeroToNine = new string[10] 
        { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tenToNineteen = new string[10]
        {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] lastZero = new string[10]
        {"zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

        if ((number >= 0) && (number < 10))
        {
            Console.WriteLine(zeroToNine[number]);
        }
        else if ((number >= 10) && (number <= 19))
        {            
            Console.WriteLine(tenToNineteen[number % 10]);
        }
        else if ((number > 19) && (number < 100))
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(lastZero[number / 10]);
            }
            else
            {
                Console.WriteLine(lastZero[number / 10] + " " + zeroToNine[number % 10]);
            }
        }
        else if (number == 100)
        {
            Console.WriteLine("one hundred");
        }
        else
        {
            Console.WriteLine("invalid number");
        }                   
    }
}

