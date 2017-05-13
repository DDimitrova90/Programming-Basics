using System;

class PointInTheFigure
{
    static void Main()         
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if ((y < 0) || (x < 0) || (x > 3 * h) || ((y > h) && (x < h)) 
            || (y > 4 * h) || ((x > 2 * h) && (y > h)))
        {
            Console.WriteLine("outside");
        }
        else if (((y > 0) && (y < h) && (x > 0) && (x < 3 * h)) ||
            ((x > h) && (x < 2 * h) && (y > h) && (y < 4 * h)) || 
            ((y == h) && (x > h) && (x < 2 * h)))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("border");
        }   
    }
}

