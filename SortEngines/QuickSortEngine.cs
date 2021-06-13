using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class QuickSortEngine : LinearSortEngine, ISortEngine
    {
        public override void Sort()
        {
            QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
        }

        private void QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int s = Partition(arr, l, r);
                if (s > 1) QuickSort(arr, l, s - 1);
                if (s + 1 < r) QuickSort(arr, s + 1, r);
            }
        }

        private int Partition(int[] arr, int l, int r)
        {
            int p = arr[l];
            int i = l;
            int j = r;
            while (i < j)
            {
                while (arr[i] <= p && i < r)
                {
                    i++;
                }
                while (arr[j] > p)
                {
                    j--;
                }
                Swap(i, j);
            }
            Swap(i, j);
            Swap(l, j);
            //memory.Add((int[])arrayToSort.Clone());
            return j;
        }
    }
}
