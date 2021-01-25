using System;
using System.Text;

namespace _02.StudentsAndWorkers
{
    abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public override string ToString()
        {
            return "Name : " + FirstName + " " + LastName;
        }
    }
}
