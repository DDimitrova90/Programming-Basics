using System;

class PointOnSegment    // https://judge.softuni.bg/Contests/Practice/Index/157#2
{
    static void Main()
    {
        int firstX = int.Parse(Console.ReadLine());
        int secondX = int.Parse(Console.ReadLine());
        int pointX = int.Parse(Console.ReadLine());

        if (firstX < secondX)
        {
            int firstDiff = Math.Abs(pointX - firstX);
            int secondDiff = Math.Abs(secondX - pointX);

            if ((pointX >= firstX) && (pointX <= secondX))
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(firstDiff, secondDiff));       
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(firstDiff, secondDiff));
            }
        }
        else
        {
            int firstDiff = Math.Abs(pointX - secondX);
            int secondDiff = Math.Abs(firstX - pointX);

            if ((pointX >= secondX) && (pointX <= firstX))
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(firstDiff, secondDiff));
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(firstDiff, secondDiff));
            }
        }   
    }
}

