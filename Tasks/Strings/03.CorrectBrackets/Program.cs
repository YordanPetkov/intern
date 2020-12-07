using System;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression;
            expression = Console.ReadLine();
            int countBrackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    countBrackets++;
                }
                if(expression[i] == ')')
                {
                    countBrackets--;
                }
                if(countBrackets < 0)
                {
                    break;
                }
            }

            if(countBrackets != 0)
            {
                Console.WriteLine("Incorrect expression.");
            }
            else
            {
                Console.WriteLine("Correct expression.");
            }
        }
    }
}
