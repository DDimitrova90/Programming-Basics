using System;
using System.Numerics;

class Tables       // https://judge.softuni.bg/Contests/Practice/Index/23#0
{
    static void Main()
    {
        BigInteger bundle1 = BigInteger.Parse(Console.ReadLine());
        BigInteger bundle2 = BigInteger.Parse(Console.ReadLine());
        BigInteger bundle3 = BigInteger.Parse(Console.ReadLine());
        BigInteger bundle4 = BigInteger.Parse(Console.ReadLine());
        BigInteger tableTops = BigInteger.Parse(Console.ReadLine());
        BigInteger tablesToBeMade = BigInteger.Parse(Console.ReadLine());

        BigInteger totalLegs = (bundle1 * 1) + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);

        if (((tableTops == tablesToBeMade) && (totalLegs >= (tablesToBeMade * 4))) || 
            ((tableTops >= tablesToBeMade) && (totalLegs == (tablesToBeMade * 4))))
        {
            Console.WriteLine("Just enough tables made: {0}", tablesToBeMade);
        }
        else if (tableTops < tablesToBeMade)
        {
            Console.WriteLine("less: {0}", tableTops - tablesToBeMade);
            Console.Write("tops needed: {0}, ", tablesToBeMade - tableTops);
            Console.WriteLine(
                totalLegs >= (tablesToBeMade * 4) ? 
                "legs needed: 0" : 
                "legs needed: {0}", 
                (tablesToBeMade * 4) - totalLegs);
        }
        else if (tableTops > tablesToBeMade)
        {
            Console.WriteLine("more: {0}", tableTops - tablesToBeMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", 
                tableTops - tablesToBeMade, totalLegs - (tablesToBeMade * 4));
        }
    }
}

