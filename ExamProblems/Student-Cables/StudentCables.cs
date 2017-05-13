using System;

class StudentCables     // https://judge.softuni.bg/Contests/Practice/Index/9#1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLength = 0;
        int count = 0;
        int studentCables = 0;
        int remainder = 0;

        for (int i = 0; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                length *= 100;
            }
            if (length >= 20)
            {
                totalLength += length;
                count++;
            }
        }

        totalLength -= (count - 1) * 3;
        studentCables = totalLength / 504;
        remainder = totalLength - (studentCables * 504);

        Console.WriteLine(studentCables);
        Console.WriteLine(remainder);
    }
}

