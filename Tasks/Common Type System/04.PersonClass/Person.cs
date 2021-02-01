using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PersonClass
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string _name, int _age = 0)
        {
            name = _name;
            if(_age == 0)
            {
                age = null;
            }
            else
            {
                age = _age;
            }
        }

        public override string ToString()
        {
            string personInformation = "";
            personInformation += name;
            if(age > 0)
            {
                personInformation += " , " + age + " years old.";
            }
            else
            {
                personInformation += " , Age is unspecified.";
            }

            return personInformation;
        }
    }
}
