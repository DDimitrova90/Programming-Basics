using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int seats = rows * columns;

        if (projection == "Premiere")
        {
            Console.WriteLine("{0:F2} leva", seats * 12.00);
        }
        else if (projection == "Normal")
        {
            Console.WriteLine("{0:F2} leva", seats * 7.50);
        }
        else
        {
            Console.WriteLine("{0:F2} leva", seats * 5.00);
        }
    }
}

