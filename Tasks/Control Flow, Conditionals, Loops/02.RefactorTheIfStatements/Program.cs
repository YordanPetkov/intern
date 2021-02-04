using System;

namespace _02.RefactorTheIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            const int MIN_X = 0;
            const int MAX_X = 5;
            const int MIN_Y = 0;
            const int MAX_Y = 5;
            bool shouldNotVisitCell = false;

            Potato potato = new Potato();
            //... 
            if (potato != null && !potato.HasNotBeenPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }

            if (x >= MIN_X && x <= MAX_X && MAX_Y >= y && MIN_Y <= y && !shouldNotVisitCell)
            {
                VisitCell();
            }
        }

        public static void Cook(Potato potato)
        {
        }

        public static void VisitCell()
        {
        }
    }
}
