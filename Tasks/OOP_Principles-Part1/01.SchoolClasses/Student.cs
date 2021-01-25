using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SchoolClasses
{
    class Student : Person
    {
        private int classNumber;
        private Class studentClass;

        public Student(string _name, int _classNumber, Class _studentClass)
        {
            name = _name;
            classNumber = _classNumber;
            studentClass = _studentClass;
        }

        public override string ToString()
        {
            string studentInformation = "";
            studentInformation += name + " N'" + classNumber + "\n";
            string classInformation = studentClass.ToString();
            studentInformation += "Class:\n" + classInformation;
            return studentInformation;

        }
    }
}
