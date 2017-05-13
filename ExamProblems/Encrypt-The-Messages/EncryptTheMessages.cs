using System;

class EncryptTheMessages   // https://judge.softuni.bg/Contests/Practice/Index/82#3
{
    static void Main()
    {
        string command = Console.ReadLine();

        while (command != "START" && command != "start")
        {
            command = Console.ReadLine();
        }

        int receivedMessages = 0;
        string encryptMessage = string.Empty;
        
        command = Console.ReadLine();

        while (command != "end" && command != "END")
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

                if ((currentSymbol >= 'a' && currentSymbol <= 'm') || 
                    (currentSymbol >= 'A' && currentSymbol <= 'M'))
                {
                    encryptMessage += (char)(currentSymbol + 13);
                }
                else if ((currentSymbol >= 'n' && currentSymbol <= 'z') || 
                    (currentSymbol >= 'N' && currentSymbol <= 'Z'))
                {
                    encryptMessage += (char)(currentSymbol - 13);
                }
                else if (currentSymbol >= '0' && currentSymbol <= '9')
                {
                    encryptMessage += currentSymbol;
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case ' ':
                            encryptMessage += '+';
                            break;
                        case ',':
                            encryptMessage += '%';
                            break;
                        case '.':
                            encryptMessage += '&';
                            break;
                        case '?':
                            encryptMessage += '#';
                            break;
                        case '!':
                            encryptMessage += '$';
                            break;
                    }
                }
            }

            encryptMessage += Environment.NewLine;    
            command = Console.ReadLine();           
        }

        if (receivedMessages == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", receivedMessages);
            Console.WriteLine(encryptMessage);
        }       
    }
}

