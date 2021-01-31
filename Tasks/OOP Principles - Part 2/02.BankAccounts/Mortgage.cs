using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(string _name, Customer _customer, double _balance, double _interestRate)
        {
            name = _name;
            customer = _customer;
            balance = _balance;
            interestRate = _interestRate;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (customer == Customer.Company)
            {
                if (months > 12)
                {
                    return ((double)(months - 12) * interestRate) + (12 * interestRate / 2);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 6)
                {
                    return ((double)months - 6) * interestRate;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
