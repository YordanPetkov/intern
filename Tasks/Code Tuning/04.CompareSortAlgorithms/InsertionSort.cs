using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    public class InsertionSort<T> : SortingAlgorithm<T>  where T : IComparable 
    {
        public InsertionSort(T[] arr) : base(arr)
        {
        }

        public void Sort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 1)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
    }
}
