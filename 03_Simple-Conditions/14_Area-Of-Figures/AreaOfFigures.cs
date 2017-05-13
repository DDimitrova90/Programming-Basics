using System;

class AreaOfFigures
{
    static void Main()
    {
        string figureType = Console.ReadLine();

        if (figureType == "square")
        {
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = squareSide * squareSide;
            Console.WriteLine("{0:#.###}", squareArea);
        }
        else if (figureType == "rectangle")
        {
            double recSideA = double.Parse(Console.ReadLine());
            double recSideB = double.Parse(Console.ReadLine());
            double rectangleArea = recSideA * recSideB;
            Console.WriteLine(Math.Round(rectangleArea, 3));
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double radiusArea = Math.PI * radius * radius;
            Console.WriteLine(Math.Round(radiusArea, 3));
        }
        else
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = (triangleSide * triangleHeight) / 2;
            Console.WriteLine(Math.Round(triangleArea, 3));
        }
    }
}

