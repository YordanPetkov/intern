using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = 10000;

            SortUtility.PrintInsertionSortTime<int>(ArrayUtility.GetRandomIntArray(numbersCount), 
                    "Insertion sort for random " + numbersCount + " integers");

            SortUtility.PrintInsertionSortTime<double>(ArrayUtility.GetRandomDoubleArray(numbersCount), 
                    "Insertion sort for random " + numbersCount + " doubles");

            SortUtility.PrintInsertionSortTime<string>(ArrayUtility.GetRandomStringArray(numbersCount), 
                    "Insertion sort for random " + numbersCount + " strings");

            SortUtility.PrintInsertionSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, true), 
                    "Insertion sort for sorted " + numbersCount + " integers");

            SortUtility.PrintInsertionSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, true), 
                    "Insertion sort for sorted " + numbersCount + " doubles");

            SortUtility.PrintInsertionSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, true), 
                    "Insertion sort for sorted " + numbersCount + " strings");

            SortUtility.PrintInsertionSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, false), 
                    "Insertion sort for sorted " + numbersCount + " integers descending");

            SortUtility.PrintInsertionSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, false), 
                    "Insertion sort for sorted " + numbersCount + " doubles descending");

            SortUtility.PrintInsertionSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, false), 
                    "Insertion sort for sorted " + numbersCount + " strings descending");

            Console.WriteLine();

            SortUtility.PrintSelectionSortTime<int>(ArrayUtility.GetRandomIntArray(numbersCount),
                    "Selection sort for random " + numbersCount + " integers");

            SortUtility.PrintSelectionSortTime<double>(ArrayUtility.GetRandomDoubleArray(numbersCount),
                    "Selection sort for random " + numbersCount + " doubles");

            SortUtility.PrintSelectionSortTime<string>(ArrayUtility.GetRandomStringArray(numbersCount),
                    "Selection sort for random " + numbersCount + " strings");

            SortUtility.PrintSelectionSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, true),
                    "Selection sort for sorted " + numbersCount + " integers");

            SortUtility.PrintSelectionSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, true),
                    "Selection sort for sorted " + numbersCount + " doubles");

            SortUtility.PrintSelectionSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, true),
                    "Selection sort for sorted " + numbersCount + " strings");

            SortUtility.PrintSelectionSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, false),
                    "Selection sort for sorted " + numbersCount + " integers descending");

            SortUtility.PrintSelectionSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, false),
                    "Selection sort for sorted " + numbersCount + " doubles descending");

            SortUtility.PrintSelectionSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, false),
                    "Selection sort for sorted " + numbersCount + " strings descending");

            Console.WriteLine();

            SortUtility.PrintQuickSortTime<int>(ArrayUtility.GetRandomIntArray(numbersCount),
                    "Quick sort for random " + numbersCount + " integers");

            SortUtility.PrintQuickSortTime<double>(ArrayUtility.GetRandomDoubleArray(numbersCount),
                    "Quick sort for random " + numbersCount + " doubles");

            SortUtility.PrintQuickSortTime<string>(ArrayUtility.GetRandomStringArray(numbersCount),
                    "Quick sort for random " + numbersCount + " strings");

            SortUtility.PrintQuickSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, true),
                    "Quick sort for sorted " + numbersCount + " integers");

            SortUtility.PrintQuickSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, true),
                    "Quick sort for sorted " + numbersCount + " doubles");

            SortUtility.PrintQuickSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, true),
                    "Quick sort for sorted " + numbersCount + " strings");

            SortUtility.PrintQuickSortTime<int>(ArrayUtility.GetSortedIntArray(numbersCount, false),
                    "Quick sort for sorted " + numbersCount + " integers descending");

            SortUtility.PrintQuickSortTime<double>(ArrayUtility.GetSortedDoubleArray(numbersCount, false),
                    "Quick sort for sorted " + numbersCount + " doubles descending");

            SortUtility.PrintQuickSortTime<string>(ArrayUtility.GetSortedStringArray(numbersCount, false),
                    "Quick sort for sorted " + numbersCount + " strings descending");
        }
    }
}
