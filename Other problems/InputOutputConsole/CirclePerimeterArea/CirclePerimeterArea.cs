using System;
class CirclePerimeterArea
{
    static void Main()
    {
        const double pi = 3.14159265359d;
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * pi * radius;
        double area = pi * radius * radius;
        Console.WriteLine("Perimeter: {0:F2}  Area: {1:F2}", perimeter, area);
    }
}
