using System;

class DecryptTheMessages    // https://judge.softuni.bg/Contests/Practice/Index/81#3
{
    static void Main()
    {
        string command = Console.ReadLine();
        int receivedMessages = 0;
        string decryptedMessage = string.Empty;

        while (command != "START" && command != "start")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "END" && command != "end")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            receivedMessages++;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                char currentSymbol = command[i];

                if ((currentSymbol >= 65 && currentSymbol <= 77) || 
                    (currentSymbol >= 97 && currentSymbol <= 109))
                {
                    decryptedMessage += (char)(currentSymbol + 13);
                }
                else if ((currentSymbol >= 78 && currentSymbol <= 90) || 
                    (currentSymbol >= 110 && currentSymbol <= 122))
                {
                    decryptedMessage += (char)(currentSymbol - 13);
                }
                else if (currentSymbol >= '0' && currentSymbol <= '9')
                {
                    decryptedMessage += currentSymbol;
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case '+':
                            decryptedMessage += ' ';
                            break;
                        case '%':
                            decryptedMessage += ',';
                            break;
                        case '&':
                            decryptedMessage += '.';
                            break;
                        case '#':
                            decryptedMessage += '?';
                            break;
                        case '$':
                            decryptedMessage += '!';
                            break;
                    }
                }
            }

            decryptedMessage += Environment.NewLine;
            command = Console.ReadLine();
        }

        if (receivedMessages == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", receivedMessages);
            Console.WriteLine(decryptedMessage);
        }
    }
}

