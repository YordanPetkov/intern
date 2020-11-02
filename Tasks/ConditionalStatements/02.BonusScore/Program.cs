using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = int.Parse(Console.ReadLine());
            if (score < 1 || score > 9)
            {
                Console.WriteLine("invalid score");
            }
            else
            {
                if (score >= 1 && score <= 3)
                {
                    score = score * 10;
                }
                else if (score >= 4 && score <= 6)
                {
                    score = score * 100;
                }
                else if (score >= 7 && score <= 9)
                {
                    score = score * 1000;
                }

                Console.WriteLine(score);
            }
            
        }
    }
}
