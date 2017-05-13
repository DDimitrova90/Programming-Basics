using System;

class PerfectGirlfriend   // https://judge.softuni.bg/Contests/Practice/Index/129#3
{
    static void Main()
    {
        string information = Console.ReadLine();

        int result = 0;
        int number = 0;
        int perfectGirls = 0;

        while (information != "Enough dates!")
        {
            result = 0;

            string[] parameters = information.Split('\\');
            string dayOfWeek = parameters[0];
            string telNum = parameters[1];
            string braSize = parameters[2];
            string girlName = parameters[3];

            switch (dayOfWeek)
            {
                case "Monday":
                    number = 1;
                    break;
                case "Tuesday":
                    number = 2;
                    break;
                case "Wednesday":
                    number = 3;
                    break;
                case "Thursday":
                    number = 4;
                    break;
                case "Friday":
                    number = 5;
                    break;
                case "Saturday":
                    number = 6;
                    break;
                case "Sunday":
                    number = 7;
                    break;
            }

            long tel = long.Parse(telNum);

            while (tel > 0)
            {
                int digit = (int)tel % 10;
                tel /= 10;
                result += digit;
            }

            result += number;

            string size = braSize.Substring(0, braSize.Length - 1);
            int sizeInt = int.Parse(size);
            char lastChar = braSize[braSize.Length - 1];

            result += sizeInt * lastChar;

            char firstChar = girlName[0];
            int length = girlName.Length;

            result -= firstChar * length;

            if (result >= 6000)
            {
                Console.WriteLine("{0} is perfect for you.", girlName);
                perfectGirls++;
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.", girlName);
            }

            information = Console.ReadLine();
        }

        Console.WriteLine(perfectGirls);
    }
}

