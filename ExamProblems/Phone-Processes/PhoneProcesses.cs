using System;

class PhoneProcesses    // https://judge.softuni.bg/Contests/Practice/Index/102#3
{                       
    static void Main()
    {
        int batteryPercentage = int.Parse(Console.ReadLine().Replace("%", ""));
        int remainingApps = 0;

        while (true)
        {
            string application = Console.ReadLine();
            if (application.ToLower() == "end") break;

            if (batteryPercentage > 15)
            {
                string[] appDetails = application.Split('_');
                int currApp = int.Parse(appDetails[1].Replace("%", ""));
                batteryPercentage -= currApp;
            }
            else
            {
                remainingApps++;
            }
        }

        if (batteryPercentage <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (batteryPercentage <= 15)
        {
            Console.WriteLine(
                "Connect charger -> {0}%{2}Programs left -> {1}",
                batteryPercentage,
                remainingApps,
                Environment.NewLine);
        }
        else
        {
            Console.WriteLine("Successful complete -> {0}%", batteryPercentage);
        }
    }
}


