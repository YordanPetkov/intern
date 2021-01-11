using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    class Call
    {

        public Call (DateTime dateCall, string phoneNumber = null, double durationCall = 0)
        {
            Date = dateCall;
            DialledPhone = phoneNumber;
            Duration = durationCall;
        }

        public DateTime Date { get; private set; }
        public string DialledPhone { get; private set; }
        public double Duration { get; private set; }
    }
}
