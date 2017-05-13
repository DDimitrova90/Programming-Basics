using System;

class BeerStock   // https://judge.softuni.bg/Contests/Practice/Index/149#1
{
    static void Main()
    {
        int reservedBeers = int.Parse(Console.ReadLine());
        string shipment = Console.ReadLine();
        shipment.Split(' ');
        long receivedBeers = 0;
        long beerDiff = 0;
        long cases = 0;
        long sixpacks = 0;
        long beers = 0;

        while (shipment != "Exam Over")
        {
            string[] parameters = shipment.Split(); 
            long amount = long.Parse(parameters[0]);  
            string type = parameters[1];

            switch (type)
            {
                case "beers":
                    receivedBeers += amount;
                    break;
                case "sixpacks":
                    receivedBeers += 6 * amount;
                    break;
                case "cases":
                    receivedBeers += 24 * amount;
                    break;
            }

            shipment = Console.ReadLine();
        }

        if (receivedBeers >= 100)
        {
            receivedBeers = receivedBeers - (receivedBeers / 100);
        }
        if (receivedBeers >= reservedBeers)
        {
            beerDiff = receivedBeers - reservedBeers;
            cases = beerDiff / 24;
            beerDiff -= 24 * cases;
            sixpacks = beerDiff / 6;
            beerDiff -= 6 * sixpacks;
            beers = beerDiff;
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers."
                , cases, sixpacks, beers);
        }
        else
        {
            beerDiff = reservedBeers - receivedBeers;
            cases = beerDiff / 24;
            beerDiff -= 24 * cases;
            sixpacks = beerDiff / 6;
            beerDiff -= 6 * sixpacks;
            beers = beerDiff;
            Console.WriteLine(
                $"Not enough beer. Beer needed: {cases} cases, {sixpacks} sixpacks and {beers} beers."); 
        }
    }
}

