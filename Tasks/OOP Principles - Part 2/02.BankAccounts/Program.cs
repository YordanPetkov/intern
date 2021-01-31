using System;

namespace _02.BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit[] deposits = { new Deposit("Ivan Ivanov", Customer.Individual, 250, 5), new Deposit("DOS", Customer.Company, 2600, 6) };
            Loan[] loans = { new Loan("Petar Georgiev", Customer.Individual, 500, 7.5), new Loan("Gmb OOD", Customer.Company, 42550, 10) };
            Mortgage[] mortgages = { new Mortgage("Kiril Petrov", Customer.Individual, 20000, 4.5), new Mortgage("RikuGMB", Customer.Company, 100000, 8) };
            deposits[0].DepositAmount(200);
            deposits[0].WithDraw(100);
            deposits[1].DepositAmount(1000);
            deposits[1].WithDraw(2000);
            loans[0].DepositAmount(500);
            mortgages[1].DepositAmount(1000);
            Console.WriteLine(deposits[0].CalculateInterestAmount(15)); 
            Console.WriteLine(deposits[1].CalculateInterestAmount(4)); 
            Console.WriteLine(loans[0].CalculateInterestAmount(8)); 
            Console.WriteLine(loans[1].CalculateInterestAmount(11)); 
            Console.WriteLine(mortgages[0].CalculateInterestAmount(9)); 
            Console.WriteLine(mortgages[1].CalculateInterestAmount(25)); 
        }
    }
}
