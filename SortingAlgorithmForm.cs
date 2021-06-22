using Algorithm_Visualisation.SortEngines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Visualisation
{
    public partial class SortingAlgorithmForm : Form
    {
        public int[] ArrayToSort { get; set; }
        private int[] BackUpArray { get; set; }
        private Graphics G { get; set; }
        private StateMemory memory;
        private int MaxVal { get; set; }
        private int NumEntries { get; set; }
        private int[] UnitWidths { get; set; }
        private int UnitHeight { get; set; }
        public bool HasAlgorithm { get; set; }
        public Dictionary<int, Brush> Brushes { get; private set; }

        private LinearSortEngine sortEngine;
        private Thread backgroundThread;
        private Thread sortingThread;
        private volatile bool isSorting;

        public SortingAlgorithmForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThreadProc()
        {
            try
            {
                while (isSorting)
                {
                    UpdateTimer(sortEngine.GetCurrentStopWatchValue());
                }
            }
            catch
            {
                isSorting = false;
            }
        }

        private void UpdateTimer(string time)
        {
            SetTextBox(time);
        }

        private void SetTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(SetTextBox), new object[] { value });
                return;
            }
            timeBox.Text = value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ArrayToSort = BackUpArray.ToArray();
            ShowArray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sortingThread = new Thread(new ThreadStart(StartSorting));
            sortingThread.Start();
            if (!btnReset.Enabled)
            {
                btnReset.Enabled = true;
            }
        }

        private void StartSorting()
        {
            isSorting = true;
            BackUpArray = ArrayToSort.ToArray();
            string selectedAlgorithm = (string)Invoke(new Func<string>(() => algorithmSelectionBox.Text));
            switch (selectedAlgorithm)
            {
                case "Insertion Sort":
                    sortEngine = new InsertionSortEngine();
                    break;

                case "Selection Sort":
                    sortEngine = new SelectionSortEngine();
                    break;

                case "Bubble Sort":
                    sortEngine = new BubbleSortEngine();
                    break;

                case "Merge Sort":
                    sortEngine = new MergeSortEngine();
                    break;

                case "Quick Sort":
                    sortEngine = new QuickSortEngine();
                    break;

                case "Heap Sort":
                    sortEngine = new HeapSortEngine();
                    break;
            }
            sortEngine.Initiate(ArrayToSort, G, panel1.Height, UnitWidths, UnitHeight);
            sortEngine.SetBrushDict(Brushes);
            UpdateTimer("");
            backgroundThread = new Thread(new ThreadStart(ThreadProc));
            backgroundThread.Start();
            sortEngine.Execute();
            memory = sortEngine.GetMemory();
            Invoke((MethodInvoker) delegate { SetPlayer(); });
            Invoke((MethodInvoker) delegate { UpdateDataBox(); });
            //SetPlayer();
            //UpdateDataBox();
            isSorting = false;
            backgroundThread.Join();
            sortingThread.Join();
        }

        private void algorithmSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HasAlgorithm = true;
            SetReady();
        }

        public void ShowArray(bool updateDataBox = true)
        {
            if (ArrayToSort.Length > 0)
            {
                G = panel1.CreateGraphics();
                NumEntries = ArrayToSort.Length;
                MaxVal = ArrayToSort.Max();
                UnitHeight = MaxVal == 0 ? 1 : panel1.Height / MaxVal;
                UnitWidths = Distribute(NumEntries, panel1.Width);
                G.FillRectangle(new SolidBrush(Color.White), 0, 0, panel1.Width, panel1.Height);

                for (int i = 0; i < NumEntries; i++)
                {
                    try
                    {
                        G.FillRectangle(Brushes.GetValueOrDefault(ArrayToSort[i]),
                                        i == 0 ? 0 : UnitWidths[..i].Sum(),
                                        panel1.Height - ArrayToSort[i] * UnitHeight,
                                        UnitWidths[i],
                                        panel1.Height);
                    }
                    catch (Exception)
                    {
                        // Ignored
                    }
                }
                if (updateDataBox)
                {
                    UpdateDataBox();
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DataForm dataForm = new DataForm();
            dataForm.SetParent(this);
            dataForm.Show();
        }

        private static int[] Distribute(int numberOfElements, int totalContainerSize)
        {
            // Creates a base array with the base values for all elements
            int baseSize = totalContainerSize / numberOfElements;
            int[] distributedArray = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                distributedArray[i] = baseSize;
            }
            // Counts how many extra values are needed for the
            // array sum to meet the total container size
            int extraValueCount = totalContainerSize - baseSize * numberOfElements;
            while (extraValueCount > 0)
            {
                // The interval of elements to add the extra value
                int extraValueInterval = (int) Math.Ceiling(decimal.Divide(numberOfElements, extraValueCount));
                int i = 0;
                while (i < numberOfElements)
                {
                    distributedArray[i] += 1;
                    extraValueCount--;
                    i += extraValueInterval;
                }
            }
            return distributedArray;
        }

        private void SetPlayer()
        {
            replaySlider.Maximum = memory.States.Count() - 1;
            replaySlider.Value = replaySlider.Maximum;
            replaySlider.Focus();
        }

        /// <summary>
        /// Sets the form in ready mode
        /// </summary>
        public void SetReady()
        {
            if (!btnStart.Enabled && ArrayToSort != null && ArrayToSort.Length > 0 && HasAlgorithm)
            {
                btnStart.Enabled = true;
            }
        }

        private void replaySlider_Scroll(object sender, EventArgs e)
        {
            int sliderValue = replaySlider.Value;
            for (int i = 0; i < NumEntries; i++)
            {
                G.FillRectangle(new SolidBrush(Color.White),
                                i == 0 ? 0 : UnitWidths[..i].Sum(),
                                0,
                                UnitWidths[i],
                                panel1.Height);
                G.FillRectangle(Brushes.GetValueOrDefault(ArrayToSort[i]),
                                i == 0 ? 0 : UnitWidths[..i].Sum(),
                                panel1.Height - ArrayToSort[i] * UnitHeight,
                                UnitWidths[i],
                                panel1.Height);
            }
            ArrayToSort = memory.States[sliderValue];
            stepBox.Text = sliderValue.ToString();
            UpdateDataBox();
            //ShowArray();
        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {
            ArrayToSort = DataForm.GenerateArrayFromString(dataTextBox.Text);
            dataSizeBox.Text = ArrayToSort.Length > 0 ? ArrayToSort.Length.ToString() : "";
            GenerateBrushDict();
            ShowArray(false);
            dataTextBox.Select(dataTextBox.Text.Length, 0);            
            SetReady();
        }

        private void UpdateDataBox()
        {
            string arrayString = "";
            foreach (int i in ArrayToSort)
            {
                arrayString += i + ", ";
            }
            dataTextBox.Text = arrayString;
            dataTextBox.Select(0, 0);
        }

        internal void GenerateBrushDict()
        {
            Brushes = new Dictionary<int, Brush>();
            foreach (int i in ArrayToSort)
            {
                Brushes.TryAdd(i, GenerateBrush(i, ArrayToSort.Max()));
            }
        }

        private static Brush GenerateBrush(int value, int maxValue)
        {
            decimal ratio = maxValue == 0 ? 0 : decimal.Divide(value, maxValue);
            int B = 0;
            int G = 0;
            int R = 0;
            if (ratio <= 0.2m)
            {
                B = (int)Math.Floor(255 * 5 * ratio);
            }
            else if (ratio <= 0.4m)
            {
                B = 255;
                G = (int)Math.Floor(255 * 5 * (ratio - 0.2m));
            }
            else if (ratio <= 0.6m)
            {
                G = 255;
                B = 255 - (int)Math.Floor(255 * 5 * (ratio - 0.4m));
            }
            else if (ratio <= 0.8m)
            {
                B = 0;
                G = 255;
                R = (int)Math.Floor(255 * 5 * (ratio - 0.6m));
            }
            else if (ratio <= 1.0m)
            {
                B = 0;
                R = 255;
                G = 255 - (int)Math.Floor(255 * 5 * (ratio - 0.8m));
            }
            Color color = Color.FromArgb(255, R, G, B);
            return new SolidBrush(color);
        }
    }
}
