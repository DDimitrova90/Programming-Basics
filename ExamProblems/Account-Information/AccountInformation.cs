using System;

class AccountInformation    // https://judge.softuni.bg/Contests/Practice/Index/50#0
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int clientID = int.Parse(Console.ReadLine());
        decimal totalAccountBalance = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}");
        Console.WriteLine($"Client id: {clientID}");
        Console.WriteLine("Total balance: {0:F2}", totalAccountBalance);
        Console.WriteLine(totalAccountBalance >= 0 ? "Active: yes" : "Active: no");
    }
}

