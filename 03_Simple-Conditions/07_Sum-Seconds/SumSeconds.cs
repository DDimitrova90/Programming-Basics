using System;

class SumSeconds
{
    static void Main()
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int fullTime = firstTime + secondTime + thirdTime;

        if (fullTime < 60)
        {
            if (fullTime < 10)
            {
                Console.WriteLine("0:0{0}", fullTime);
            }
            else
            {
                Console.WriteLine("0:{0}", fullTime);
            }            
        }
        else if ((fullTime >= 60) && (fullTime <= 119))
        {
            int leftTime = fullTime - 60;

            if (leftTime < 10)
            {
                Console.WriteLine("1:0{0}", leftTime);
            }
            else
            {
                Console.WriteLine("1:{0}", leftTime);
            }          
        }
        else
        {
            int leftTime = fullTime - 120;

            if (leftTime < 10)
            {
                Console.WriteLine("2:0{0}", leftTime);
            }
            else
            {
                Console.WriteLine("2:{0}", leftTime);
            }           
        }
    }
}

