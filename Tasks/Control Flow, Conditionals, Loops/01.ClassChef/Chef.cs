using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassChef
{
    public class Chef
    {
        
        public void Cook()
        {
            Vegetable[] vegetables = { GetPotato(), GetCarrot() }; 
            Bowl bowl;

            foreach(var vegetable in vegetables)
            {
                Peel(vegetable);
                Cut(vegetable);
            }

            bowl = GetBowl();

            foreach (var vegetable in vegetables)
            {
                bowl.Add(carrot);
            }
        }

        private Potato GetPotato()
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private void Cut(Vegetable potato)
        {
            //...
        }
    }
}
