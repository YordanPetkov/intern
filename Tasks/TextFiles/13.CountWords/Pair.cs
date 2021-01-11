using System;
using System.Collections.Generic;
using System.Text;

namespace _13.CountWords
{
    class Pair
    {
        public Pair(string item1 = "", int item2 = 0)
        {
            Item1 = item1;
            Item2 = item2;
        }
        public string Item1 { get; set; }
        public int Item2 { get; set; }
    }
}
