using System;

class PetarsGame     // https://judge.softuni.bg/Contests/Practice/Index/82#1
{
    static void Main()
    {
        ulong startNum = ulong.Parse(Console.ReadLine());
        ulong endNum = ulong.Parse(Console.ReadLine());
        string strReplace = Console.ReadLine();
        decimal sum = 0;

        for (ulong i = startNum; i < endNum; i++)
        {
            if (startNum % 5 == 0)
            {
                sum += startNum;
            }
            else
            {               
                sum += startNum % 5;
            }
            startNum++;
        }

        string sumStr = Convert.ToString(sum);

        if (sum % 2 == 0)
        {
            string firstDigit = sumStr.Substring(0, 1);
            sumStr = sumStr.Replace(firstDigit, strReplace);           
        }
        else
        {           
            string lastDigit = sumStr.Substring(sumStr.Length - 1, 1);
            sumStr = sumStr.Replace(lastDigit, strReplace);
        }

        Console.WriteLine(sumStr);
    }
}

