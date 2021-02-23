using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    public abstract class SortingAlgorithm<T> where T : IComparable 
    {
        protected T[] array;
        public SortingAlgorithm(T[] arr)
        {
            this.array = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.array[i] = arr[i];
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
