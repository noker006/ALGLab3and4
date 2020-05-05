using System;
using System.Collections.Generic;
using System.Text;

namespace AlgLab3
{
    class Exercise4
    {
        public static int[] CountKeysEqual(int[] array, int n, int m)
        {
            int key;

            int[] equal = new int[m];
            for (int i = 0; i < m; i++)
            {
                equal[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                key = array[i];
                equal[key - 1]++;
            }
            return equal;
        }

        public static int[] CountKeyLess(int[] equal, int m)
        {
            int[] less = new int[m];
            less[0] = 0;
            for (int j = 1; j < m; j++)
            {
                less[j] = less[j - 1] + equal[j - 1];
            }
            return less;
        }

        public static int[] GetRandArray(int arraySize,int maxRandNum)
        {
            Random rnd = new Random();
            int[] newArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                newArray[i] = rnd.Next(1, maxRandNum);
            }
            return newArray;
        }

        public static int[] RearrangeProcedure(int[] array, int[] less, int n, int m)
        {
            int key, index;

            int[] b = new int[n];
            int[] next = new int[m];

            for (int j = 0; j < m; j++)
            {
                next[j] = less[j] + 1;
            }

            for (int i = 0; i < n; i++)
            {
                key = array[i];
                index = next[key - 1];
                b[index - 1] = array[i];
                next[key - 1]++;
            }

            return b;
        }
    }
}
