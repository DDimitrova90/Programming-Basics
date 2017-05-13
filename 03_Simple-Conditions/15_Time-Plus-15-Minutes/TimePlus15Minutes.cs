using System;

class TimePlus15Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int minAfterTime = minutes + 15;

        if (minAfterTime > 59)
        {
            hours += 1;
            minAfterTime -= 60;

            if (hours > 23)
            {
                Console.WriteLine("0:{0:00}", minAfterTime);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", hours, minAfterTime);
            } 
        }
        else
        {
            Console.WriteLine("{0}:{1:00}", hours, minAfterTime);
        }
    }
}

