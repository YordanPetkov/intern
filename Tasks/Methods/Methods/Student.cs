using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }
        public DateTime BirthDay { get; set; }

        public bool IsOlderThan(Student other)
        {
            if(other == null)
            {
                throw new Exception("Student instance is null.");
            }

            if(this.BirthDay == null || other.BirthDay == null)
            {
                throw new Exception("Student birthday is undefined.");
            }

            return this.BirthDay > other.BirthDay;
        }
    }
}