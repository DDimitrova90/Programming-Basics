using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();    
        string[] array = input.Split(' ');  // array with separated elements
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < array.Length; i++)
        {
            int number = int.Parse(array[i]);  
              
            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_procuct = {0}", oddProduct);
            Console.WriteLine("even_procuct = {0}", evenProduct);
        }
    }
}
