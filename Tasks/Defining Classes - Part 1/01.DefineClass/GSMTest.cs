using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    class GSMTest
    {
        private GSM[] gsm = new GSM[5];

        public GSMTest()
        {
            gsm[0] = new GSM("Chromebook Tab 10", "Acer");
            gsm[1] = new GSM("IPhone 12 mini", "Apple", new Display(5.4, 167216));
            gsm[2] = new GSM("Venue 8 7000", "Dell", new Display(8.4), new Battery(type:BatteryType.LiIon, hoursIdle:48, hoursTalk:10.5));
            gsm[3] = new GSM("P smart 2021", "Huawei", new Display(6.67), new Battery(type:BatteryType.LiPoly, hoursIdle:40, hoursTalk:9.1), 1200);
            gsm[4] = new GSM("K12 Pro", "Lenovo", new Display(6.8, 16747216), new Battery("Lithium polymer", BatteryType.LiPoly, 47.7, 8.9), 980, "Peter Jackson");
        }

        public override string ToString()
        {
            string information = "";

            foreach(var gsms in gsm)
            {
                information += "\n" + gsms.ToString();
            }

            information += "\n" + "IPhone 4S : " + GSM.IPhone4S + "\n";
            return information;
        }
    }
}
