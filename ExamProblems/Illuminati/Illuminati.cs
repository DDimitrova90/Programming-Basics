using System;

class Illuminati     // https://judge.softuni.bg/Contests/Practice/Index/5#1
{
    static void Main()
    {
        string message = Console.ReadLine().ToLower();
        int vowelsNum = 0;
        int sum = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if ( message[i] == 'a' || message[i] == 'e' || 
                message[i] == 'i' || message[i] == 'o' ||
                message[i] == 'u')
            {
                vowelsNum++;
            }

            switch (message[i])
            {
                case 'a':
                    sum += 65;
                    break;
                case 'e':
                    sum += 69;
                    break;
                case 'i':
                    sum += 73;
                    break;
                case 'o':
                    sum += 79;
                    break;
                case 'u':
                    sum += 85;
                    break;
            }
        }

        Console.WriteLine(vowelsNum);
        Console.WriteLine(sum);
    }
}

