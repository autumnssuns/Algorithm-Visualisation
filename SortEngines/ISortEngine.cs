using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Visualisation.SortEngines
{
    interface ISortEngine
    {
        void Sort();
        StateMemory GetMemory();
    }
}
