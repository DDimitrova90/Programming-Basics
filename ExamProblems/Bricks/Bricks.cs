using System;

class Bricks   // https://judge.softuni.bg/Contests/Practice/Index/157#1
{
    static void Main()
    {
        int bricks = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int course = workers * capacity;
        double totalCourses = (double)bricks / course;

        Console.WriteLine(Math.Ceiling(totalCourses));
    }
}

