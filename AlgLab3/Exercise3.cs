using System;
using System.Collections.Generic;
using System.Text;

namespace AlgLab3
{
    class Exercise3
    {
        public static int[,] GetRandomArrays(int k, int n)
        {
            int[,] x = new int[k, n];
            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                int[] nTempArray = new int[n];
                for (int j = 0; j < n; j++)
                {
                    nTempArray[j] = rand.Next(65, 90);
                }
                Array.Sort(nTempArray);
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = nTempArray[j];
                }
            }
            return x;
        }
        public static int[] MergeSort(int[] array)
        {
            int r = array.Length;
            int middle = array.Length / 2;

            if (r <= 1)
            {
                return array;
            }
            int[] subArray1 = new int[middle];
            int[] subArray2 = new int[r - middle];
            for (int i = 0; i < middle; i++)
            {
                subArray1[i] = array[i];
            }
            int count = 0;
            for (int i = middle; i < r; i++)
            {
                subArray2[count] = array[i];
                count++;
            }
            subArray1 = MergeSort(subArray1);
            subArray2 = MergeSort(subArray2);
            return Merge(subArray1, subArray2);
        }
        public static int[] Merge(int[] array1, int[] array2)
        {
            int r = array1.Length + array2.Length;
            int[] newArray = new int[r];
            int[] subArray1 = new int[array1.Length + 1];
            int[] subArray2 = new int[array2.Length + 1];
            subArray1[array1.Length] = int.MaxValue;
            subArray2[array2.Length] = int.MaxValue;
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                subArray1[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                subArray2[i] = array2[i];
            }
            int count = 0;
            int k = 0;
            while (k < r)
            {
                if (subArray1[count] <= subArray2[j])
                {
                    newArray[k] = subArray1[count];
                    count++;
                }
                else
                {
                    newArray[k] = subArray2[j];
                    j++;
                }
                k++;
            }
            return newArray;
        }

        public static char[] Convert(int[] array, int k, int n)
        {
            char[] buf = new char[k * n];

            for (int i = 0; i < k * n; i++)
            {
                buf[i] = (char)array[i];
            }

            return buf;
        }
        public static void WriteArrays(int[,] x, int k, int n)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(String.Format("Array{0} ", i));
                for (int j = 0; j < n; j++)
                {
                    Console.Write(x[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }


        public static void WriteArrayWithMessage(char[] array, string message = "")
        {
            Console.Write("\n" + message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
