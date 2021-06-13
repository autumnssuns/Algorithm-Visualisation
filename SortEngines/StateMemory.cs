using System.Collections;
using System.Collections.Generic;

namespace Algorithm_Visualisation.SortEngines
{
    public class StateMemory
    {
        public List<int[]> States { get; set; }
        public List<int>[] Iterations { get; set; }
        public StateMemory()
        {
            States = new List<int[]>();
        }

        public void Add(int[] state)
        {
            States.Add((int[]) state.Clone());
        }
    }
}