using System;

class WeirdCombinations     // https://judge.softuni.bg/Contests/Practice/Index/37#3
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string combinations = string.Empty;
        int count = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = 0; j < sequence.Length; j++)
            {
                for (int k = 0; k < sequence.Length; k++)
                {
                    for (int l = 0; l < sequence.Length; l++)
                    {
                        for (int m = 0; m < sequence.Length; m++)
                        {
                            combinations += "" + sequence[i] + sequence[j] 
                                               + sequence[k] + sequence[l] 
                                               + sequence[m];
                            count++;

                            if (count == n + 1)
                            {
                                Console.WriteLine(combinations);
                                return;
                            }

                            combinations = "";
                        }
                    }
                }
            }
        }

        if (count < n + 1)
        {
            Console.WriteLine("No");
        }
    }
}

