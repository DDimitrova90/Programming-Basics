using System;

class CompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneCompany = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine()

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: ({3})\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", 
            companyName, companyAddress, phoneCompany, faxNumber, webSite, firstName, lastName, age, managerPhone);
    }
}

