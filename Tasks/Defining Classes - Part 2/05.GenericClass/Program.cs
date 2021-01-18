using System;

namespace _05.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(5);
            list.Add(0);
            list.Add(1);
            list.Add(2);
            Console.WriteLine(list.ToString());
            list.AddAt(1, 5);
            list.AddAt(2, 7);
            list.Add(8);
            Console.WriteLine(list.ToString());
            list.RemoveAt(2);
            Console.WriteLine(list.Find(5));
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Min().ToString());
            Console.WriteLine(list.Max().ToString());
        }
    }
}
