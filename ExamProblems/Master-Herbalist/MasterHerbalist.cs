using System;

class MasterHerbalist    // https://judge.softuni.bg/Contests/Practice/Index/149#3
{
    static void Main()
    {
        int expenses = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int herbs = 0;
        int days = 0;
        double money = 0;

        while (command != "Season Over")
        {
            days++;
            string[] parameters = command.Split();
            int hours = int.Parse(parameters[0]);
            string path = parameters[1];
            int price = int.Parse(parameters[2]);

            for (int j = 0; j <= hours; j++)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    hours--;
                    if (path[i] == 'H')
                    {
                        herbs++;
                    }
                    if (hours <= 0)
                    {
                        break;
                    }
                }
            } 

            money += herbs * price;
            herbs = 0;
            command = Console.ReadLine();
        }

        double moneyAverage = money / days;
        double moneyNeeded = (expenses * days) - money;

        if (moneyAverage >= expenses)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", 
                moneyAverage - expenses);
        }
        else
        {
            Console.WriteLine("We are in the red. Money needed: {0:F0}.",
                moneyNeeded);
        }
    }
}

