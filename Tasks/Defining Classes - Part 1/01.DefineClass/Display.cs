using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefineClass
{
    class Display
    {
        public Display()
        {
            Size = 0;
            NumberColors = 0;
        }
        public Display(double size)
        {
            this.Size = size;
            NumberColors = 0;
        }
        public Display(double size, long numberColors)
        {
            this.Size = size;
            this.NumberColors = numberColors;
        }

        public double Size { get; private set; }
        public long NumberColors { get; private set; }

        public override string ToString()
        {
            string text = "";
            text += "\n" + "display size => " + Size + "\'\'";
            text += "\n" + "display number of colors => " + NumberColors;
            return text;
        }
    }
}
