using System;

class SumSecondsNew
{
    static void Main()
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int fullTime = firstTime + secondTime + thirdTime;
        int minutes = fullTime / 60;
        int seconds = fullTime % 60;

        Console.WriteLine("{0}:{1:00}", minutes, seconds);
    }
}

