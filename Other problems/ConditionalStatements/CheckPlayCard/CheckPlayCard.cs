using System;

class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter a character and I will tell you if it is classical play card: ");
        string card = Console.ReadLine();

        switch (card)
        {
            case "2": 
            case "3": 
            case "4": 
            case "5": 
            case "6": 
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": Console.WriteLine("Yes");
                break;
            default:
                Console.WriteLine("No");
                break;
        }
    }
}

