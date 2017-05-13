using System;

class Money     // https://judge.softuni.bg/Contests/Practice/Index/233#0
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double joans = double.Parse(Console.ReadLine());
        double comission = double.Parse(Console.ReadLine());

        double bitcoinsToBgn = bitcoins * 1168d;
        double joansToUsn = joans * 0.15;
        double usnToBgn = joansToUsn * 1.76;
        double totalMoney = bitcoinsToBgn + usnToBgn;
        double totalMoneyEur = totalMoney / 1.95;
        totalMoneyEur -= totalMoneyEur * (comission / 100d);

        Console.WriteLine(totalMoneyEur);
    }
}

