using System;

class BookOrders      // https://judge.softuni.bg/Contests/Practice/Index/23#1
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine());
        int boughtBooks = 0;
        double orderPrice = 0;
        double totalPrice = 0;
        int booksPerOrder = 0;
        double discount = 0; ;

        for (int i = 0; i < orders; i++)
        {
            int packetsNum = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());

            if (packetsNum < 10)
            {
                discount = 0;
            }
            else if (packetsNum >= 10 && packetsNum <= 109)
            {
                discount = (packetsNum / 10) + 4;
            }
            else
            {
                discount = 15;
            }


            booksPerOrder = packetsNum * booksPerPacket;
            boughtBooks += booksPerOrder;
            orderPrice = bookPrice * ((100 - discount) / 100) * booksPerOrder;
            totalPrice += orderPrice;
        }

        Console.WriteLine(boughtBooks);
        Console.WriteLine("{0:F2}", totalPrice);
    }
}

