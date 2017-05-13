using System;

class FourFactors   // https://judge.softuni.bg/Contests/Practice/Index/100#0
{
    static void Main()
    {
        uint fG = uint.Parse(Console.ReadLine());
        uint fGA = uint.Parse(Console.ReadLine());
        uint threeP = uint.Parse(Console.ReadLine());
        uint tOV = uint.Parse(Console.ReadLine());
        uint oRB = uint.Parse(Console.ReadLine());
        uint oppDRB = uint.Parse(Console.ReadLine());
        uint fT = uint.Parse(Console.ReadLine());
        uint fTA = uint.Parse(Console.ReadLine());

        double eFGP = (fG + (0.5d * threeP)) / fGA;
        double tOVP = tOV / (fGA + (0.44d * fTA) + tOV);
        double oRBP = (double)oRB / (oRB + oppDRB);
        double fTP = (double)fT / fGA;

        Console.WriteLine("eFG% {0:F3}", eFGP);
        Console.WriteLine("TOV% {0:F3}", tOVP);
        Console.WriteLine("ORB% {0:F3}", oRBP);
        Console.WriteLine("FT% {0:F3}", fTP);
    }
}

