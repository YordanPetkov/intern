using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    class GSMCallHistoryTest
    {
        private GSM gsm = new GSM("K12 Pro", "Lenovo", new Display(6.8, 16747216), new Battery("Lithium polymer", BatteryType.LiPoly, 47.7, 8.9), 980, "Peter Jackson");

        public GSMCallHistoryTest()
        {
            gsm.AddCall(new Call(new DateTime(2020, 12, 11, 8, 51, 11), "0889785253", 158));
            gsm.AddCall(new Call(new DateTime(2020, 12, 11, 9, 55, 21), "0889125845", 83));
            gsm.AddCall(new Call(new DateTime(2020, 12, 24, 12, 34, 9), "0888551535", 1561));
            gsm.AddCall(new Call(new DateTime(2021, 1, 1, 0, 2, 31), "0887583889", 186));
            gsm.AddCall(new Call(new DateTime(2021, 1, 6, 11, 43, 49), "0888551535", 892));
            Console.WriteLine("Call History : \n{0}", this.ToString());
            Console.WriteLine("Price : {0:0.00}$", gsm.CallPrice(0.37));
            this.RemoveLongestCall();
            Console.WriteLine("Price : {0:0.00}$", gsm.CallPrice(0.37));
            gsm.ClearHistory();
            Console.WriteLine("Call History : \n{0}", this.ToString());
        }

        public override string ToString()
        {
            string text = "";

            foreach (var call in gsm.CallHistory)
            {
                text += call.Date.ToString() + " " + call.DialledPhone + " " + call.Duration + "\n";
            }

            return text;
        }
        public void RemoveLongestCall()
        {
            double longestDuration = double.MinValue;
            Call longestCall = new Call(DateTime.MinValue);

            foreach (var call in gsm.CallHistory)
            {
                if(call.Duration > longestDuration)
                {
                    longestDuration = call.Duration;
                    longestCall = call;
                }
            }

            gsm.DeleteCall(longestCall);
        }
    }
}
