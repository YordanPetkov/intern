using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    class GSM
    {
        private static string iPhone4S;
        public GSM(string model, string manufacturer, Display display = null, Battery battery = null, double price = 0, string owner = null)
        {
            iPhone4S = "The iPhone 4S, like other iPhones, runs iOS, Apple's mobile operating system. The user interface of iOS is based on the concept of direct manipulation, using multi-touch gestures. Interface control elements consist of sliders, switches, and buttons. The response to user input is immediate and provides a fluid interface.[36] Interaction with the OS includes gestures such as swipe, tap, pinch, and reverse pinch, all of which have specific definitions within the context of the iOS operating system and its multi-touch interface.";
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            GsmDisplay = display;
            GsmBattery = battery;
            CallHistory = new List<Call>();
        }

        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public double Price { get; private set; }
        public string Owner { get; private set; }
        public Display GsmDisplay { get; private set; }
        public Battery GsmBattery { get; private set; }
        public static string IPhone4S { get { return iPhone4S; } }
        public List<Call> CallHistory { get; private set; }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }
        public void ClearHistory()
        {
            CallHistory.Clear();
        }
        public double CallPrice(double pricePerMinute)
        {
            double price = 0;

            foreach (Call call in CallHistory)
            {
                price += call.Duration / 60.0 * pricePerMinute;
            }

            return price;
        }
        public override string ToString()
        {
            string text = "";
            text += "model => " + Model;
            text += "\n" + "manufacturer => " + Manufacturer;
            text += "\n" + "price => " + Price + "$";
            text += "\n" + "owner => " + Owner;
            if (GsmDisplay != null)
            {
                text += GsmDisplay.ToString();
            }
            if(GsmBattery != null)
            {
                text += GsmBattery.ToString();
            }
            text += "\n";
            return text;
        }

    }
}
