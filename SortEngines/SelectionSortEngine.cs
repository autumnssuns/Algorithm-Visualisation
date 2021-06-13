using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class SelectionSortEngine : LinearSortEngine, ISortEngine
    {
        public override void Sort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arrayToSort[j] < arrayToSort[min])
                    {
                        min = j;
                    }
                }
                Swap(i, min);
                //memory.Add(arrayToSort);
            }
        }
    }
}