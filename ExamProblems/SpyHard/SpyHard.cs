using System;
using System.Linq;

class SpyHard
{
    static void Main()
    {
        // Input
        int numericSystem = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        message = message.ToLower();   

        // Encrypt
        int sum = 0;
        for (int i = 0; i < message.Length; i++)     
        {
            char symbol = message[i];   
            if ((symbol >= 'a') && (symbol <= 'z'))      
            {
                int position = symbol - 'a' + 1;     
                sum += position;    
            }
            else
            {
                sum += symbol;
            }      
        }

        string result = numericSystem.ToString() + message.Length;
        string baseResult = "";

        while (sum > 0)
        {
            int modul = sum % numericSystem;
            sum /= numericSystem;
            baseResult += modul;
        }

        string reversedBase = string.Join("", baseResult.Reverse());

        // Output
        Console.WriteLine(result + reversedBase);
    }
}

