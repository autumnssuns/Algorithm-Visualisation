using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class MergeSortEngine : LinearSortEngine, ISortEngine
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    Assign(k, L[i]);
                    //arr[k] = L[i];
                    i++;
                }
                else
                {
                    //arr[k] = R[j];
                    Assign(k, R[j]);
                    j++;
                }
                k++;
                //memory.Add((int[])arrayToSort.Clone());
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                Assign(k, L[i]);
                //arr[k] = L[i];
                i++;
                k++;
                //memory.Add((int[])arrayToSort.Clone());
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                Assign(k, R[j]);
                //arr[k] = R[j];
                j++;
                k++;
                //memory.Add((int[])arrayToSort.Clone());
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }

        public override void Sort()
        {
            MergeSort(arrayToSort, 0, arrayToSort.Length - 1);
        }
    }
}
