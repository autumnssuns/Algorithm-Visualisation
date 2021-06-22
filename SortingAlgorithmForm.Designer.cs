
namespace Algorithm_Visualisation
{
    partial class SortingAlgorithmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithmSelectionBox = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.replaySlider = new System.Windows.Forms.TrackBar();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dataSizeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // algorithmSelectionBox
            // 
            this.algorithmSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmSelectionBox.FormattingEnabled = true;
            this.algorithmSelectionBox.Items.AddRange(new object[] {
            "Insertion Sort",
            "Selection Sort",
            "Bubble Sort",
            "Merge Sort",
            "Quick Sort",
            "Heap Sort"});
            this.algorithmSelectionBox.Location = new System.Drawing.Point(80, 25);
            this.algorithmSelectionBox.Name = "algorithmSelectionBox";
            this.algorithmSelectionBox.Size = new System.Drawing.Size(97, 23);
            this.algorithmSelectionBox.TabIndex = 2;
            this.algorithmSelectionBox.SelectedIndexChanged += new System.EventHandler(this.algorithmSelectionBox_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(335, 529);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(13, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 440);
            this.panel1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(416, 529);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(761, 25);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(27, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "...";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // replaySlider
            // 
            this.replaySlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaySlider.Location = new System.Drawing.Point(80, 500);
            this.replaySlider.Name = "replaySlider";
            this.replaySlider.Size = new System.Drawing.Size(708, 45);
            this.replaySlider.TabIndex = 8;
            this.replaySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.replaySlider.Scroll += new System.EventHandler(this.replaySlider_Scroll);
            // 
            // stepBox
            // 
            this.stepBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stepBox.Location = new System.Drawing.Point(13, 500);
            this.stepBox.Name = "stepBox";
            this.stepBox.PlaceholderText = "Step";
            this.stepBox.Size = new System.Drawing.Size(61, 23);
            this.stepBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTextBox.Location = new System.Drawing.Point(274, 25);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(481, 23);
            this.dataTextBox.TabIndex = 11;
            this.dataTextBox.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeBox.Location = new System.Drawing.Point(13, 530);
            this.timeBox.Name = "timeBox";
            this.timeBox.PlaceholderText = "Time";
            this.timeBox.Size = new System.Drawing.Size(61, 23);
            this.timeBox.TabIndex = 12;
            // 
            // dataSizeBox
            // 
            this.dataSizeBox.Location = new System.Drawing.Point(224, 25);
            this.dataSizeBox.Name = "dataSizeBox";
            this.dataSizeBox.PlaceholderText = "Size";
            this.dataSizeBox.Size = new System.Drawing.Size(44, 23);
            this.dataSizeBox.TabIndex = 13;
            // 
            // SortingAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.dataSizeBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.replaySlider);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.algorithmSelectionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SortingAlgorithmForm";
            this.Text = "Sorting Algorithms Visualisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox algorithmSelectionBox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button generateButton;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar replaySlider;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox dataSizeBox;
    }
}

