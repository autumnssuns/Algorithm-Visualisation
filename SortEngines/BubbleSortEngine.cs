using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class BubbleSortEngine : LinearSortEngine, ISortEngine
    {
        public override void Sort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arrayToSort[j + 1] < arrayToSort[j])
                    {
                        Swap(j, j + 1);
                        //memory.Add(arrayToSort);
                    }
                }
            }
        }
    }
}
