using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class HeapSortEngine : LinearSortEngine, ISortEngine
    {
        public override void Sort()
        {
            HeapSort(arrayToSort);
        }

        // convert a complete binary tree into a heap
        private void HeapBottomUp(int[] data)
        {
            int n = data.Length;
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                int k = i;
                int v = data[i];
                bool heap = false;
                while ((!heap) && ((2 * k + 1) <= (n - 1)))
                {
                    int j = 2 * k + 1;  //the left child of k
                    if (j < (n - 1))   //k has two children
                        if (data[j] < data[j + 1])
                            j = j + 1;  //j is the larger child of k
                    if (v >= data[j])
                        heap = true;
                    else
                    {
                        Assign(k, data[j]);
                        //data[k] = data[j];
                        k = j;
                    }
                }
                Assign(k, v);
                //data[k] = v;
            }
        }

        // sort the elements in an array 
        private void HeapSort(int[] data)
        {
            //Use the HeapBottomUp procedure to convert the array, data, into a heap
            HeapBottomUp(data);

            //repeatly remove the maximum key from the heap and then rebuild the heap
            for (int i = 0; i <= data.Length - 2; i++)
            {
                MaxKeyDelete(data, data.Length - i);
            }
        }

        //delete the maximum key and rebuild the heap
        private void MaxKeyDelete(int[] data, int size)
        {
            //1. Exchange the root’s key with the last key K of the heap;
            Swap(0, size - 1);

            //2. Decrease the heap’s size by 1;
            int n = size - 1;

            //3. “Heapify” the complete binary tree.
            bool heap = false;
            int k = 0;
            int v = data[0];
            while ((!heap) && ((2 * k + 1) <= (n - 1)))
            {
                int j = 2 * k + 1; //the left child of k
                if (j < (n - 1))   //k has two children
                    if (data[j] < data[j + 1])
                        j = j + 1;  //j is the larger child of k
                if (v >= data[j])
                    heap = true;
                else
                {
                    Assign(k, data[j]);
                    k = j;
                }
            }
            Assign(k, v);
        }
    }
}
