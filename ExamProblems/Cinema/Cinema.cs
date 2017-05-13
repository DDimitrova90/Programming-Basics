using System;

class Cinema     // https://judge.softuni.bg/Contests/Practice/Index/5#0
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int seats = rows * columns;

        switch (projectionType)
        {
            case "Premiere":
                Console.WriteLine("{0:F2} leva", seats * 12.00);
                break;
            case "Normal":
                Console.WriteLine("{0:F2} leva", seats * 7.50);
                break;
            case "Discount":
                Console.WriteLine("{0:F2} leva", seats * 5.00);
                break;
        }
    }
}

