using System;

class TrainingLab         // 06.03.2016 https://judge.softuni.bg/Contests/Practice/Index/169#0
{
    static void Main()
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double heightInCM = height * 100;
        double widthInCM = width * 100;

        int rows = (int)(heightInCM / 120);
        double widthMinusCorridor = widthInCM - 100;
        int tables = (int)(widthMinusCorridor / 70);
        int seats = (rows * tables) - 3;
        Console.WriteLine(seats);
    }
}

