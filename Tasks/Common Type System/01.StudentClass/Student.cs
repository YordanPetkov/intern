using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StudentClass
{
    enum Specialties
    {
        ComputerScience,
        SoftwareEngineering,
        Biology,
        Science,
        Chemistry,
        Math,
        History,
        Law
    }
    enum Universities
    {
        SofiaUniversity,
        TechnicalUniversity,
    }
    enum Faculties
    {
        MathAndInformatic,
        Biology,
        History,
        FacultyOfLaw
    }
    class Student : ICloneable
    {
        public Student(string _name, string _ssn)
        {
            string[] splitedName = _name.Split(" ");
            FirstName = splitedName[0];
            MiddleName = splitedName[1];
            LastName = splitedName[2];
            SSN = _ssn;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermamentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }


        public void setInformation(string _permamentAddress, string _mobilePhone, string _eMail)
        {
            PermamentAddress = _permamentAddress;
            MobilePhone = _mobilePhone;
            EMail = _eMail;
        }

        public void enrollStudent(int _course, Specialties _specialty, Universities _university, Faculties _faculty)
        {
            Course = _course;
            Specialty = _specialty;
            University = _university;
            Faculty = _faculty;
        }

        public override bool Equals(object _student)
        {
            if(this.ToString() == _student.ToString())
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string studentInformation = "";
            studentInformation += FirstName + " " + MiddleName + " " + LastName + "\nSSN: " + SSN + " permament address: " + PermamentAddress;
            studentInformation += " mobile phone: " + MobilePhone + " e_mail: " + EMail + "\n";
            studentInformation += "Course : " + Course + " Specialty : " + Enum.GetName(typeof(Specialties), Specialty);
            studentInformation += " University : " + Enum.GetName(typeof(Universities), University) + " Faculty : " + Enum.GetName(typeof(Faculties), Faculty);
            return studentInformation;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public void Clone(Student _student)
        {
            this.FirstName = _student.FirstName;
            this.MiddleName = _student.MiddleName;
            this.LastName = _student.LastName;
            this.SSN = _student.SSN;
            this.setInformation(_student.PermamentAddress, _student.MobilePhone, _student.EMail);
            this.enrollStudent(_student.Course, _student.Specialty, _student.University, _student.Faculty);
        }

        public static bool operator ==(Student first, Student second)
        {
            if(first.ToString() == second.ToString())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student first, Student second)
        {
            if (first.ToString() != second.ToString())
            {
                return true;
            }
            return false;
        }
    }
}
