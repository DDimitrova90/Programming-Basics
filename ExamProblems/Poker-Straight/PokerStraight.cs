using System;

class PokerStraight    // https://judge.softuni.bg/Contests/Practice/Index/10#3
{
    static void Main()
    {
        int targetWeight = int.Parse(Console.ReadLine());
        int facesWeight = 0;
        int suitsWeight = 0;
        int totalWeight = 0;
        int counter = 0;

        for (int i = 1; i <= 14; i++)
        {
            for (int j = 1; j <= 14; j++)
            {
                for (int k = 1; k <= 14; k++)
                {
                    for (int l = 1; l <= 14; l++)
                    {
                        for (int m = 1; m <= 14; m++)
                        {
                            if ((j == i + 1) && (k == j + 1) && (l == k + 1) && (m == l + 1))
                            {
                                facesWeight += (10 * i) + (20 * j) + (30 * k) + (40 * l) + (50 * m);
                                
                                for (int n = 1; n <= 4; n++)
                                {
                                    for (int o = 1; o <= 4; o++)
                                    {
                                        for (int p = 1; p <= 4; p++)
                                        {
                                            for (int q = 1; q <= 4; q++)
                                            {
                                                for (int r = 1; r <= 4; r++)
                                                {
                                                    suitsWeight += n + o + p + q + r;
                                                    totalWeight = facesWeight + suitsWeight;

                                                    if (totalWeight == targetWeight)
                                                    {
                                                        counter++;
                                                    }

                                                    suitsWeight = 0;
                                                    totalWeight = 0;
                                                } 
                                            }
                                        }
                                    }
                                } 
                            }

                            facesWeight = 0;
                        }
                    }
                }
            }
        }

        Console.WriteLine(counter);
    }
}

