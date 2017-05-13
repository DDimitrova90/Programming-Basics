using System;

class Numerology     // https://judge.softuni.bg/Contests/Practice/Index/36#1
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parameters = input.Split();
        string[] date = parameters[0].Split('.') ;
        string username = parameters[1];
        int day = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[2]);

        long dateProduct = day * month * year;

        if (month % 2 != 0)
        {
            dateProduct = dateProduct * dateProduct;
        }

        long productUsername = 0;

        for (int i = 0; i < username.Length; i++)
        {
            if (username[i] >= 48 && username[i] <= 57)
            {
                productUsername += username[i] - 48;
            }
            else if (username[i] >= 97 && username[i] <= 122)
            {
                productUsername += username[i] - 96;
            }
            else if (username[i] >= 65 && username[i] <= 90)
            {
                productUsername += (username[i] - 64) * 2;
            }
        }

        dateProduct += productUsername;

        while (dateProduct > 13)
        {
            long celestialNum = 0;
            while (dateProduct > 0)
            {
                celestialNum += dateProduct % 10;
                dateProduct /= 10;
            }

            dateProduct = celestialNum;       
        }

        Console.WriteLine(dateProduct);
    }
}

