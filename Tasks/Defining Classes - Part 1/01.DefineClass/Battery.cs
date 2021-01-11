using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
        LiPoly
    }
    class Battery
    {
        public Battery(string model = null,BatteryType type = 0, double hoursIdle = 0, double hoursTalk = 0)
        {
            this.Model = model;
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model { get; private set; }
        public BatteryType Type { get; private set; }
        public double HoursIdle { get; private set; }
        public double HoursTalk { get; private set; }

        public override string ToString()
        {
            string text = "";
            text += "\n" + "battery model => " + Model;
            text += "\n" + "battery type => " + Type;
            text += "\n" + "battery hours idle => " + HoursIdle;
            text += "\n" + "battery hours talk => " + HoursTalk;
            return text;
        }
    }
}
