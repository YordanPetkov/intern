using System;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Yordan";
            string lastName = "Petkov";
            ushort age = 20;
            char gender = 'm';
            string personalID = "0048182201";
            ulong employeeNumber = 27561107;

            Console.WriteLine("Name : {0} {1}", firstName, lastName);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("Genger : {0}", gender);
            Console.WriteLine("Personal ID number : {0}", personalID);
            Console.WriteLine("Unique employee number : {0}", employeeNumber);
        }
    }
}