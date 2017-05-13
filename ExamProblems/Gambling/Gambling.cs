using System;

class Gambling
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] housesHand = Console.ReadLine().Split();
        
        int houseStrength = 0;

        for (int i = 0; i < housesHand.Length; i++)
        {
            switch (housesHand[i])
            {
                case "J":
                    houseStrength += 11;
                    break;
                case "Q":
                    houseStrength += 12;
                    break;
                case "K":
                    houseStrength += 13;
                    break;
                case "A":
                    houseStrength += 14;
                    break;
                default:
                    houseStrength += int.Parse(housesHand[i]);
                    break;
            }
        }

        int possibleHands = 0;
        int winningHands = 0;
        int currentHand = 0;

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                for (int k = 2; k < 14; k++)
                {
                    for (int l = 2; l < 14; l++)
                    {
                        possibleHands++;
                        currentHand = i + j + k + l;

                        if (currentHand > houseStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }

        decimal ratio = (decimal)winningHands / possibleHands;
        decimal expectedWinnings = ratio * 2M * cash;

        Console.WriteLine(ratio >= 0.5M ? "DRAW" : "FOLD");
        Console.WriteLine("{0:F2}", expectedWinnings);
    }
}

