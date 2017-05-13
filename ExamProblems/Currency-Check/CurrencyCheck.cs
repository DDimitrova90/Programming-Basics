using System;

class CurrencyCheck    // https://judge.softuni.bg/Contests/Practice/Index/79#0
{
    static void Main()
    {
        uint priceInRubles = uint.Parse(Console.ReadLine());
        uint priceInDollars = uint.Parse(Console.ReadLine());
        uint priceInEuro = uint.Parse(Console.ReadLine());
        uint offerB = uint.Parse(Console.ReadLine());
        uint offerM = uint.Parse(Console.ReadLine());

        decimal firstOffer = priceInRubles * 0.035M;
        decimal secondOffer = priceInDollars * 1.5M;
        decimal thirdOffer = priceInEuro * 1.95M;
        decimal fourthOffer = offerB / 2M;

        decimal minOffer = decimal.MaxValue;
        minOffer = Math.Min(firstOffer, minOffer);
        minOffer = Math.Min(secondOffer, minOffer);
        minOffer = Math.Min(thirdOffer, minOffer);
        minOffer = Math.Min(fourthOffer, minOffer);
        minOffer = Math.Min(offerM, minOffer);

        Console.WriteLine("{0:F2}", minOffer);

        //if (firstOffer < secondOffer && firstOffer < thirdOffer && 
        //    firstOffer < fourthOffer && firstOffer < offerM)
        //{
        //    Console.WriteLine("{0:F2}", firstOffer);
        //}
        //else if (secondOffer < thirdOffer && secondOffer < fourthOffer && secondOffer < offerM)
        //{
        //    Console.WriteLine("{0:F2}", secondOffer);
        //}
        //else if (thirdOffer < fourthOffer && thirdOffer < offerM)
        //{
        //    Console.WriteLine("{0:F2}", thirdOffer);
        //}
        //else if (fourthOffer < offerM)
        //{
        //    Console.WriteLine("{0:F2}", fourthOffer);
        //}
        //else
        //{
        //    Console.WriteLine("{0:F2}", offerM);
        //}

    }
}

