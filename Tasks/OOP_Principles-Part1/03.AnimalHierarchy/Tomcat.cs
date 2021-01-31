using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string _name, int _age = 0) : base(_name, _age, "male")
        {
        }

        public override string ToString()
        {
            return name + " is " + age + " year old cat.Tomcat say '" + ProduceSound() + "'.";
        }
    }
}
