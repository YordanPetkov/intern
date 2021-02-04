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
                bowl.Add(vegetable);
            }
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
        }

        private void Peel(Vegetable vegetable)
        {
        }
    }
}
