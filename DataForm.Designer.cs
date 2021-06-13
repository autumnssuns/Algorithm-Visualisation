
namespace Algorithm_Visualisation
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandomise = new System.Windows.Forms.Button();
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elementCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRandomise
            // 
            this.btnRandomise.Location = new System.Drawing.Point(713, 10);
            this.btnRandomise.Name = "btnRandomise";
            this.btnRandomise.Size = new System.Drawing.Size(75, 23);
            this.btnRandomise.TabIndex = 0;
            this.btnRandomise.Text = "Randomise";
            this.btnRandomise.UseVisualStyleBackColor = true;
            this.btnRandomise.Click += new System.EventHandler(this.btnRandomise_Click);
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.AllowDrop = true;
            this.arrayTextBox.Location = new System.Drawing.Point(13, 39);
            this.arrayTextBox.Multiline = true;
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.PlaceholderText = "Enter your array of integers, separated by commas \",\"";
            this.arrayTextBox.Size = new System.Drawing.Size(775, 399);
            this.arrayTextBox.TabIndex = 1;
            this.arrayTextBox.TextChanged += new System.EventHandler(this.arrayTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Elements";
            // 
            // elementCount
            // 
            this.elementCount.Location = new System.Drawing.Point(135, 10);
            this.elementCount.Name = "elementCount";
            this.elementCount.Size = new System.Drawing.Size(70, 23);
            this.elementCount.TabIndex = 3;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayTextBox);
            this.Controls.Add(this.btnRandomise);
            this.Name = "DataForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomise;
        private System.Windows.Forms.TextBox arrayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elementCount;
    }
}