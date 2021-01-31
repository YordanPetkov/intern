using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string _name, int _age = 0) : base(_name, _age, "female")
        {
        }

        public override string ToString()
        {
            return name + " is " + age + " year old cat.Kitten say '" + ProduceSound() + "'.";
        }
    }
}
