﻿namespace Astranomical_Processing
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstArrayDisplay = new System.Windows.Forms.ListBox();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnMidRange = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.txtMidRangeOutput = new System.Windows.Forms.TextBox();
            this.txtModeOutput = new System.Windows.Forms.TextBox();
            this.txtAverageOutput = new System.Windows.Forms.TextBox();
            this.txtRangeOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(228, 76);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstArrayDisplay
            // 
            this.lstArrayDisplay.FormattingEnabled = true;
            this.lstArrayDisplay.Location = new System.Drawing.Point(12, 132);
            this.lstArrayDisplay.Name = "lstArrayDisplay";
            this.lstArrayDisplay.Size = new System.Drawing.Size(188, 160);
            this.lstArrayDisplay.TabIndex = 3;
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(228, 35);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(75, 23);
            this.btnEnterData.TabIndex = 4;
            this.btnEnterData.Text = "Enter";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(388, 76);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnLinearSearch.TabIndex = 5;
            this.btnLinearSearch.Text = "Sequential";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            // 
            // btnMidRange
            // 
            this.btnMidRange.Location = new System.Drawing.Point(228, 132);
            this.btnMidRange.Name = "btnMidRange";
            this.btnMidRange.Size = new System.Drawing.Size(75, 23);
            this.btnMidRange.TabIndex = 6;
            this.btnMidRange.Text = "Mid-Range";
            this.btnMidRange.UseVisualStyleBackColor = true;
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(388, 132);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(75, 23);
            this.btnMode.TabIndex = 7;
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(228, 203);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(388, 203);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(75, 23);
            this.btnRange.TabIndex = 9;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = true;
            // 
            // txtMidRangeOutput
            // 
            this.txtMidRangeOutput.Location = new System.Drawing.Point(228, 162);
            this.txtMidRangeOutput.Name = "txtMidRangeOutput";
            this.txtMidRangeOutput.Size = new System.Drawing.Size(100, 20);
            this.txtMidRangeOutput.TabIndex = 10;
            // 
            // txtModeOutput
            // 
            this.txtModeOutput.Location = new System.Drawing.Point(388, 161);
            this.txtModeOutput.Name = "txtModeOutput";
            this.txtModeOutput.Size = new System.Drawing.Size(100, 20);
            this.txtModeOutput.TabIndex = 11;
            // 
            // txtAverageOutput
            // 
            this.txtAverageOutput.Location = new System.Drawing.Point(228, 233);
            this.txtAverageOutput.Name = "txtAverageOutput";
            this.txtAverageOutput.Size = new System.Drawing.Size(100, 20);
            this.txtAverageOutput.TabIndex = 12;
            // 
            // txtRangeOutput
            // 
            this.txtRangeOutput.Location = new System.Drawing.Point(388, 233);
            this.txtRangeOutput.Name = "txtRangeOutput";
            this.txtRangeOutput.Size = new System.Drawing.Size(100, 20);
            this.txtRangeOutput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Bar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRangeOutput);
            this.Controls.Add(this.txtAverageOutput);
            this.Controls.Add(this.txtModeOutput);
            this.Controls.Add(this.txtMidRangeOutput);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnMidRange);
            this.Controls.Add(this.btnLinearSearch);
            this.Controls.Add(this.btnEnterData);
            this.Controls.Add(this.lstArrayDisplay);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstArrayDisplay;
        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.Button btnMidRange;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox txtMidRangeOutput;
        private System.Windows.Forms.TextBox txtModeOutput;
        private System.Windows.Forms.TextBox txtAverageOutput;
        private System.Windows.Forms.TextBox txtRangeOutput;
        private System.Windows.Forms.Label label1;
    }
}

