using System;

class BullsAndCows    // https://judge.softuni.bg/Contests/Practice/Index/1#3
{                      
    static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        bool noSalution = true;

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        int secret1 = (secretNum / 1000) % 10;
                        int secret2 = (secretNum / 100) % 10;
                        int secret3 = (secretNum / 10) % 10;
                        int secret4 = secretNum % 10;

                        int guess1 = d1;
                        int guess2 = d2;
                        int guess3 = d3;
                        int guess4 = d4;

                        int bulls = 0;
                        int cows = 0;

                        if (d1 == secret1)
                        {
                            bulls++;
                            secret1 = -1;
                            d1 = -2;
                        }
                        if (d2 == secret2)
                        {
                            bulls++;
                            secret2 = -1;
                            d2 = -2;
                        }
                        if (d3 == secret3)
                        {
                            bulls++;
                            secret3 = -1;
                            d3 = -2;
                        }
                        if (d4 == secret4)
                        {
                            bulls++;
                            secret4 = -1;
                            d4 = -2;
                        }

                        if (d1 == secret2)
                        {
                            cows++;
                            secret2 = -1;
                        }
                        else if (d1 == secret3)
                        {
                            cows++;
                            secret3 = -1;
                        }
                        else if (d1 == secret4)
                        {
                            cows++;
                            secret4 = -1;
                        }

                        if (d2 == secret1)
                        {
                            cows++;
                            secret1 = -1;
                        }
                        else if (d2 == secret3)
                        {
                            cows++;
                            secret3 = -1;
                        }
                        else if (d2 == secret4)
                        {
                            cows++;
                            secret4 = -1;
                        }

                        if (d3 == secret1)
                        {
                            cows++;
                            secret1 = -1;
                        }
                        else if (d3 == secret2)
                        {
                            cows++;
                            secret2 = -1;
                        }
                        else if (d3 == secret4)
                        {
                            cows++;
                            secret4 = -1;
                        }

                        if (d4 == secret1)
                        {
                            cows++;
                            secret1 = -1;
                        }
                        else if (d4 == secret2)
                        {
                            cows++;
                            secret2 = -1;
                        }
                        else if (d4 == secret3)
                        {
                            cows++;
                            secret3 = -1;
                        }

                        d1 = guess1;
                        d2 = guess2;
                        d3 = guess3;
                        d4 = guess4;

                        if (bulls == targetBulls && cows == targetCows)
                        {
                            Console.Write("" + d1 + d2 + d3 + d4 + " ");
                            noSalution = false;
                        }
                    }
                }
            }
        }

        if (noSalution)
        {
            Console.WriteLine("No");
        }
    }
}

