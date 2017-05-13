using System;

class Numbers0100ToTextNew
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int tens = number / 10;
        int ones = number % 10;

        string numberAsWord = "";

        if (number == 10)
        {
            numberAsWord = "ten";
        }

        if (number == 11)
        {
            numberAsWord = "eleven";
        }

        if (number == 12)
        {
            numberAsWord = "twelve";
        }

        if (number == 13)
        {
            numberAsWord = "thirteen";
        }

        if (number == 14)
        {
            numberAsWord = "fourteen";
        }

        if (number == 15)
        {
            numberAsWord = "fifteen";
        }

        if (number == 16)
        {
            numberAsWord = "sixteen";
        }

        if (number == 17)
        {
            numberAsWord = "seventeen";
        }

        if (number == 18)
        {
            numberAsWord = "eighteen";
        }

        if (number == 19)
        {
            numberAsWord = "nineteen";
        }

        if (numberAsWord != "")
        {
            Console.WriteLine(numberAsWord);
            return;                             //spira izpulnenieto natatuk
        }


        if (tens == 2)
        {
            numberAsWord = "twenty";
        }

        if (tens == 3)
        {
            numberAsWord = "thirty";
        }

        if (tens == 4)
        {
            numberAsWord = "fourty";
        }

        if (tens == 5)
        {
            numberAsWord = "fifty";
        }

        if (tens == 6)
        {
            numberAsWord = "sixty";
        }

        if (tens == 7)
        {
            numberAsWord = "seventy";
        }

        if (tens == 8)
        {
            numberAsWord = "eighty";
        }

        if (tens == 9)
        {
            numberAsWord = "ninety";
        }


        if (ones == 1)
        {
            numberAsWord += " one";
        }

        if (ones == 2)
        {
            numberAsWord += " two";
        }

        if (ones == 3)
        {
            numberAsWord += " three";
        }

        if (ones == 4)
        {
            numberAsWord += " four";
        }

        if (ones == 5)
        {
            numberAsWord += " five";
        }

        if (ones == 6)
        {
            numberAsWord += " six";
        }

        if (ones == 7)
        {
            numberAsWord += " seven";
        }

        if (ones == 8)
        {
            numberAsWord += " eight";
        }

        if (ones == 9)
        {
            numberAsWord += " nine";
        }

        if (number == 100)
        {
            numberAsWord = "one hundred";
        }

        if (number == 0)
        {
            numberAsWord = "zero";
        }

        Console.WriteLine(numberAsWord.Trim());     //.Trim() maha vsichki prazni mesta predi i sled string-a
    }
}

