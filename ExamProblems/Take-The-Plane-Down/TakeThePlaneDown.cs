using System;

class TakeThePlaneDown   // https://judge.softuni.bg/Contests/Practice/Index/138#1
{
    static void Main()
    {
        int centerX = int.Parse(Console.ReadLine());
        int centerY = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int planeNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < planeNum; i++)                  
        {                                                   
            int planeX = int.Parse(Console.ReadLine());     // a^2 + b^2 = c^2
            int planeY = int.Parse(Console.ReadLine());

            int planeDistanceX = planeX - centerX;    
            int planeDistanceY = planeY - centerY;    
            double distanceToPlane = 
                Math.Sqrt((planeDistanceX * planeDistanceX) + 
                (planeDistanceY * planeDistanceY));

            if (radius >= distanceToPlane)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
            }           
        }
    }
}

