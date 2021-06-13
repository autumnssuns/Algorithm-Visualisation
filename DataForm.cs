using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Visualisation
{
    public partial class DataForm : Form
    {
        private string arrayString;
        private int NumEntries;
        private int MaxVal;
        private SortingAlgorithmForm parentForm;
        private static Regex regex = new Regex(@"([0-9]+)", RegexOptions.Compiled);

        public DataForm()
        {
            InitializeComponent();
        }

        public void SetParent(SortingAlgorithmForm parentForm)
        {
            this.parentForm = parentForm;
            if (parentForm.ArrayToSort != null)
            {
                foreach (int i in parentForm.ArrayToSort)
                {
                    arrayString += i + ", ";
                }
                elementCount.Text = parentForm.ArrayToSort.Length.ToString();
                arrayTextBox.Text = arrayString;
            }
        }

        private void btnRandomise_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(elementCount.Text, out int NumEntries) || NumEntries > parentForm.panel1.Width)
            {
                NumEntries = parentForm.panel1.Width;
            }
            MaxVal = parentForm.panel1.Height;
            parentForm.ArrayToSort = new int[NumEntries];
            Random rand = new Random();
            for (int i = 0; i < NumEntries; i++)
            {
                parentForm.ArrayToSort[i] = rand.Next(0, MaxVal);
            }
            arrayString = "";
            UpdateArrayTextBox();
        }

        private void arrayTextBox_TextChanged(object sender, EventArgs e)
        {
            parentForm.ArrayToSort = GenerateArrayFromString(arrayTextBox.Text);
            elementCount.Text = parentForm.ArrayToSort.Length.ToString();
            UpdateParent();
        }

        private void UpdateArrayTextBox()
        {
            foreach (int i in parentForm.ArrayToSort)
            {
                arrayString += i + ", ";
            }
            elementCount.Text = parentForm.ArrayToSort.Length.ToString();
            arrayTextBox.Text = arrayString;
            UpdateParent();
        }

        private void UpdateParent()
        {
            parentForm.GenerateBrushDict();
            parentForm.ShowArray();
            parentForm.HasData = true;
            parentForm.SetReady();
        }

        public static int[] GenerateArrayFromString(string str)
        {
            MatchCollection matches = regex.Matches(str);
            int count = matches.Count;
            int[] returnArray = new int[count];
            int i = 0;
            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int value))
                {
                    returnArray[i] = value;
                    i++;
                }
            }
            return returnArray;
        }
    }
}
