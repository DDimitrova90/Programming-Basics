using System;

class PrintDeckOf52CardsNew
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] colours = { "\u2663", "\u2666", "\u2665", "\u2660" };

        foreach (var card in cards)
        {
            foreach (var colour in colours)
            {
                Console.Write("{0,2}", card);
                Console.Write("{0,2} ", colour);
            }

            Console.WriteLine();
        }
    }
}

