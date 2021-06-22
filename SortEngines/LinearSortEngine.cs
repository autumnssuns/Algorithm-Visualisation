using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Visualisation.SortEngines
{
    abstract class LinearSortEngine : ISortEngine
    {
        protected int[] arrayToSort;
        protected Dictionary<int, Brush> brushes;
        protected Graphics g;
        protected StateMemory memory;
        protected int MaxVal;
        protected int[] UnitWidths;
        protected int UnitHeight;
        protected int MaxHeight;
        protected int n;
        protected readonly Brush WhiteBrush = new SolidBrush(Color.White);
        protected readonly Brush BlackBrush = new SolidBrush(Color.Black);
        public Stopwatch Watch { get; protected set; }

        public LinearSortEngine Initiate(int[] arrayToSort, Graphics g, int MaxHeight, int[] UnitWidths, int UnitHeight)
        {
            this.arrayToSort = arrayToSort;
            this.g = g;
            this.MaxHeight = MaxHeight;
            this.UnitWidths = UnitWidths;
            this.UnitHeight = UnitHeight;
            Watch = new Stopwatch();
            memory = new StateMemory();
            memory.Add((int[])arrayToSort.Clone());
            MaxVal = arrayToSort.Max();
            n = arrayToSort.Length;
            return this;
        }

        protected void Swap(int i, int v)
        {
            int temp = arrayToSort[i];
            Assign(i, arrayToSort[v], save: false);
            Assign(v, temp);
        }

        protected void Assign(int i, int value, bool save = true)
        {
            arrayToSort[i] = value;
            try
            {
                g.FillRectangle(WhiteBrush,
                i == 0 ? 0 : UnitWidths[..i].Sum(),
                0,
                UnitWidths[i],
                MaxHeight);
                g.FillRectangle(brushes.GetValueOrDefault(value),
                                i == 0 ? 0 : UnitWidths[..i].Sum(),
                                MaxHeight - arrayToSort[i] * UnitHeight,
                                UnitWidths[i],
                                MaxHeight);
            }
            catch (Exception)
            {
                // Ignored
            }

            if (save)
            {
                memory.Add((int[])arrayToSort.Clone());
            }
        }

        public StateMemory GetMemory()
        {
            return memory;
        }

        public virtual void Execute()
        {
            Watch.Restart();
            Sort();
            Watch.Stop();
        }

        public abstract void Sort();

        public string GetCurrentStopWatchValue()
        {
            Watch.Stop();
            Watch.Start();
            TimeSpan ts = Watch.Elapsed;
            string elapsedTime;
            object[] tsValues = new object[] { ts.Milliseconds / 10, ts.Seconds, ts.Minutes, ts.Hours, ts.Days };
            string format = "{1:00}.{0:00}";
            int counter = 1;
            if (ts.TotalMinutes >= 1)
            {
                counter++;
                format = "{" + $"{counter}:00" + "}:" + format;
            }
            if (ts.TotalHours >= 1)
            {
                counter++;
                format = "{" + $"{counter}:00" + "}:" + format;
            }
            if (ts.TotalDays >= 1)
            {
                counter++;
                format = "{" + $"{counter}:00" + "}:" + format;
            }
            elapsedTime = string.Format(format,
                                tsValues[0..(counter + 1)]);
            return elapsedTime;
        }

        internal void SetBrushDict(Dictionary<int, Brush> brushes)
        {
            this.brushes = brushes;
        }
    }
}
