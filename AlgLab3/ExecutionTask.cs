using System;
using System.Collections.Generic;
using System.Text;

namespace AlgLab3
{
    class ExecutionTask
    {
        public static void Ex2Main()
        {
            int k, n;
            Console.Write("Enter num Arrays: ");
            k = Int32.Parse(Console.ReadLine());
            Console.Write("Enter size of arrays: ");
            n = Int32.Parse(Console.ReadLine());
            int[,] randArrays = Exercise2.GetRandomArrays(k, n);
            Exercise2.WriteArrays(randArrays, k, n);
            int[] reqArray = Exercise2.Un(n,k, randArrays);
            Exercise2.WriteArrayWithMessage(reqArray, "United array: ");
            reqArray = Exercise2.MergeSort(reqArray);
            Exercise2.WriteArrayWithMessage(reqArray, "Sorted array: ");
        }

        public static void Ex3Main()
        {
            int k, n;
            Console.Write("Enter num Arrays: ");
            k = Int32.Parse(Console.ReadLine());
            Console.Write("Enter size of arrays: ");
            n = Int32.Parse(Console.ReadLine());
            int[,] randArrays = Exercise3.GetRandomArrays(k, n);
            Exercise2.WriteArrays(randArrays, k, n);
            int[] reqArray = Exercise2.Un(n, k, randArrays);
            char[] arraychar = Exercise3.Convert(reqArray, k,n); 
            Exercise3.WriteArrayWithMessage(arraychar, "United array: ");
            reqArray = Exercise3.MergeSort(reqArray);
            arraychar = Exercise3.Convert(reqArray, k, n);
            Exercise3.WriteArrayWithMessage(arraychar, "Sorted array: ");
        }
        public static void Ex4Main()
        {
            Console.WriteLine("Enter Size array | Max random num :");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int maxRandNum = Convert.ToInt32(Console.ReadLine());

            int[] reqArray = Exercise4.GetRandArray(arraySize, maxRandNum);

            Console.WriteLine("\nArray: ");

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(reqArray[i] + " ");
            }

            int[] equal =Exercise4.CountKeysEqual(reqArray, arraySize, arraySize);
            int[] less = Exercise4.CountKeyLess(equal, maxRandNum);

            int[] newArray2 = Exercise4.RearrangeProcedure(reqArray, less, arraySize, maxRandNum);

            Console.WriteLine("\nRearanged array: ");

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(newArray2[i] + " ");
            }
        }

    }
}
