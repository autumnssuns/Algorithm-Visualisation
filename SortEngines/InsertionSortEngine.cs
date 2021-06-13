using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    class InsertionSortEngine : LinearSortEngine, ISortEngine
    {
        public override void Sort()
        {
            for (int i = 1; i < n; i++)
            {
                int v = arrayToSort[i];
                int j = i - 1;
                while (j >= 0 && arrayToSort[j] > v)
                {
                    Assign(j + 1, arrayToSort[j]);
                    j = j - 1;
                }
                Assign(j + 1, v);
                //memory.Add(arrayToSort);
            }
        }
    }
}
