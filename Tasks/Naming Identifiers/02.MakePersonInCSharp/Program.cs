﻿using System;

namespace _02.MakePersonInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void MakePerson(int personIdentifier)
        {
            Person person = new Person();
            person.Age = personIdentifier;

            if(personIdentifier % 2 == 0)
            {
                person.Name = "The strong man";
                person.Sex = Sex.Male;
            }

            else
            {
                person.Name = "The beautiful girl";
                person.Sex = Sex.Female;
            }
        }
    }
}
