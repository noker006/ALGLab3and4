using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgLab4.Model
{
    class Model_sorts
    {
        public static Dictionary<int, double> getExecutionTimeByArraySizeRadixSort(int arraySize, int step)
        {
            Dictionary<int, double> timeArraySize = new Dictionary<int, double>();
            Stopwatch stopwatch = new Stopwatch();
            int[] requireArray;
            int amountIteration = arraySize / step;
            int count = 0;
            for (int i = 0; i < amountIteration; i++)
            {
                count += step;
                requireArray = getRandomArray(count);

                stopwatch.Start();
                RadixSort.radixsort(requireArray, requireArray.Length);
                stopwatch.Stop();

                timeArraySize.Add(requireArray.Length, stopwatch.ElapsedMilliseconds);
            }
            return timeArraySize;
        }

        public static Dictionary<int, double> getExecutionTimeByArraySizeQuickSort(int arraySize, int step)
        {
            Dictionary<int, double> timeArraySize = new Dictionary<int, double>();
            Stopwatch stopwatch = new Stopwatch();
            int[] requireArray;
            int amountIteration = arraySize / step;
            int count = 0;
            for (int i = 0; i < amountIteration; i++)
            {
                count += step;
                requireArray = getRandomArray(count);

                stopwatch.Start();
                Quicksort.quicksort(requireArray, 0, requireArray.Length - 1);
                stopwatch.Stop();

                timeArraySize.Add(requireArray.Length, stopwatch.ElapsedMilliseconds);
            }
            return timeArraySize;
        }

        public static Dictionary<int, double> getExecutionTimeByArraySizeSelectionSortt(int arraySize, int step)
        {
            Dictionary<int, double> timeArraySize = new Dictionary<int, double>();
            Stopwatch stopwatch = new Stopwatch();
            int[] requireArray;
            int amountIteration = arraySize / step;
            int count = 0;
            for (int i = 0; i < amountIteration; i++)
            {
                count += step;
                requireArray = getRandomArray(count);

                stopwatch.Start();
                SelectionSort.Sort(requireArray);
                stopwatch.Stop();

                timeArraySize.Add(requireArray.Length, stopwatch.ElapsedMilliseconds);
            }
            return timeArraySize;
        }


        private static int[] getRandomArray(int sizeArray)
        {
            int[] reqArray = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                Random rand = new Random(i);
                reqArray[i] = rand.Next(0, 100000);
            }
            return reqArray;
        } 

    }
}
