using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab4.Model
{
    public class RadixSort
    {
        public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        // A function to do counting sort of arr[] according to  
        // the digit represented by exp.  
        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; 
            int i;
            int[] count = new int[10];

            //initializing all elements of count to 0 
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]  
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            //output array  
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
 
        public static void radixsort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits  
            int m = getMax(arr, n);

            // Do counting sort for every digit.exp is 10^i  
            // where i is current digit number  
            for (int exp = 1; m / exp > 0; exp *= 10)
            countSort(arr, n, exp);
        }
    }
}
