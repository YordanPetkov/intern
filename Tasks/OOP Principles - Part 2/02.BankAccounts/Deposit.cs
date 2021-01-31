using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BankAccounts
{
    class Deposit : Account
    {
        public Deposit(string _name, Customer _customer, double _balance, double _interestRate)
        {
            name = _name;
            customer = _customer;
            balance = _balance;
            interestRate = _interestRate;
        }

        public override double CalculateInterestAmount(int months)
        {
            if(balance > 0 && balance <= 1000)
            {
                return 0;
            }
            else
            {
                return months * interestRate;
            } 
        }

        public void WithDraw(double _money)
        {
            if(_money > balance)
            {
                Console.WriteLine("Not enough balance.");
            }
            else
            {
                balance -= _money;
                Console.WriteLine(name + " : ");
                Console.WriteLine("Current balance : {0}.", balance);
            }
            
        }
    }
}
