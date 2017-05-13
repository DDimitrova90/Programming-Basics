using System;

class DetectiveBoev    // https://judge.softuni.bg/Contests/Practice/Index/100#1
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string message = Console.ReadLine();

        int secretWordSum = 0;
        int mask = 0;
        char symbol;
        string newMessage = "";

        for (int i = 0; i < secretWord.Length; i++)
        {
            secretWordSum += secretWord[i];
        }

        while (secretWordSum > 9)    
        {
            while (secretWordSum != 0)
            {
                mask += secretWordSum % 10;
                secretWordSum = secretWordSum / 10;
            }
            secretWordSum = mask;

            if (mask > 9)
            {
                mask = 0;
            }
        }

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] % mask == 0)
            {
                symbol = message[i];
                symbol += (char)mask;
                newMessage += symbol;
            }
            else
            {
                symbol = message[i];
                symbol -= (char)mask;
                newMessage += symbol;
            }
        }

        char[] finalResult = newMessage.ToCharArray();
        Array.Reverse(finalResult);

        Console.WriteLine(finalResult);       
    }
}

