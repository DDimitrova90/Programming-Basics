using System;

class VegetableMarket     // 26.03.2016 https://judge.softuni.bg/Contests/Practice/Index/179#0
{
    static void Main()
    {
        decimal vegetablesPrice = decimal.Parse(Console.ReadLine());
        decimal fruitsPrice = decimal.Parse(Console.ReadLine());
        int vegetablesKilos = int.Parse(Console.ReadLine());
        int fruitsKilos = int.Parse(Console.ReadLine());

        decimal vegetablesIncome = vegetablesPrice * vegetablesKilos;
        decimal fruitsIncome = fruitsPrice * fruitsKilos;
        decimal totalIncome = vegetablesIncome + fruitsIncome;
        decimal totalIncomeEUR = totalIncome / 1.94M;    
         
        Console.WriteLine(totalIncomeEUR);
    }
}
