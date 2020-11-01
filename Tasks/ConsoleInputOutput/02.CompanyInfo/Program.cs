using System;

namespace _02.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName;
            string companyAddress;
            string phoneNumber;
            string faxNumber;
            string webSite;
            string managerFirstName;
            string managerLastName;
            int managerAge;
            string managerPhone;

            companyName = Console.ReadLine();
            companyAddress = Console.ReadLine();
            phoneNumber = Console.ReadLine();
            faxNumber = Console.ReadLine();
            webSite = Console.ReadLine();
            managerFirstName = Console.ReadLine();
            managerLastName = Console.ReadLine();
            managerAge = int.Parse(Console.ReadLine());
            managerPhone = Console.ReadLine();


            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            if (faxNumber == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}",faxNumber);
            }

            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName, managerLastName, managerAge, managerPhone);

            
        }
    }
}
