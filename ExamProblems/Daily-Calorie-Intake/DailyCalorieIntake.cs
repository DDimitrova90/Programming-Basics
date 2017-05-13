using System;

class DailyCalorieIntake   // https://judge.softuni.bg/Contests/Practice/Index/104#0
{
    static void Main()
    {
        int weightPounds = int.Parse(Console.ReadLine());
        int heightInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workouts = int.Parse(Console.ReadLine());
        double bmr = 0;
        double dci = 0;

        double weightKg = weightPounds / 2.2d;
        double heightCm = heightInches * 2.54d;

        if (gender == 'f')
        {
            bmr = 655 + (9.563d * weightKg) + (1.850d * heightCm) - (4.676d * age);
        }
        else
        {
            bmr = 66.5d + (13.75d * weightKg) + (5.003d * heightCm) - (6.755d * age);
        }

        if (workouts <= 0)
        {
            dci = bmr * 1.2d;
        }
        else if (workouts >= 1 && workouts <= 3)
        {
            dci = bmr * 1.375d;
        }
        else if (workouts >= 4 && workouts <= 6)
        {
            dci = bmr * 1.55d;
        }
        else if (workouts >= 7 && workouts <= 9)
        {
            dci = bmr * 1.725d;
        }
        else if (workouts > 9)
        {
            dci = bmr * 1.9d;
        }

        Console.WriteLine(Math.Floor(dci));
    }
}

