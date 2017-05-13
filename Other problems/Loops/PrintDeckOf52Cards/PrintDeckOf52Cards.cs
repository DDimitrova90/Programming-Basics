using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int rows = 0; rows < cardFaces.Length; rows++)
        {
            for (int suits = 1; suits <= 4; suits++)
            {
                switch (suits)
                {
                    case 1: Console.Write(cardFaces[rows] + "♣" + " "); break;
                    case 2: Console.Write(cardFaces[rows] + "♦" + " "); break;
                    case 3: Console.Write(cardFaces[rows] + "♥" + " "); break;
                    case 4: Console.Write(cardFaces[rows] + "♠"); break;
                }
            }

            Console.WriteLine();
        }
    }
}

