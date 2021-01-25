using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StudentsAndWorkers
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string _firstName , string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }

        public double WeekSalary { get { return weekSalary; } set { weekSalary = value; } }
        public double WorkHoursPerDay { 
            get { return workHoursPerDay; }
            set
            {
                if (value >= 0)
                {
                    workHoursPerDay = value;
                }
                else
                {
                    workHoursPerDay = 0;
                }
            }
        }
        public double MoneyPerHour()
        {
            if(WorkHoursPerDay == 0)
            {
                return Math.Round(weekSalary / 5, 2);
            }
            return Math.Round(WeekSalary / (5 * WorkHoursPerDay), 2);
        }

        public override string ToString()
        {
            return "Name : " + FirstName + " " + LastName + " Week Salary : " + WeekSalary + " Work hours/day : " + WorkHoursPerDay + " Money/hour : " + MoneyPerHour();
        }
    }
}
