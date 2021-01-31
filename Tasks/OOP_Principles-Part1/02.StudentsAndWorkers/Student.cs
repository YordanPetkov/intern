using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StudentsAndWorkers
{
    class Student : Human
    {
        private double grade;

        public Student(string _firstName, string _lastName, double _grade)
        {
            firstName = _firstName;
            lastName = _lastName;
            grade = _grade;
        }

        public double Grade { get { return grade; } set { grade = value; } }

        public override string ToString()
        {
            return "Name : " + FirstName + " " + LastName + " Grade : " + Grade;
        }

    }
}
