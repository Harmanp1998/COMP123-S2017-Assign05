﻿namespace COMP123_S2017_Assign05
{
    partial class BMICalculatorForm
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
            this.BMITableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.HeightInputTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ImerialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIResultsTextBox = new System.Windows.Forms.TextBox();
            this.BMITableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayout
            // 
            this.BMITableLayout.ColumnCount = 2;
            this.BMITableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayout.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMITableLayout.Controls.Add(this.MyHeightLabel, 0, 1);
            this.BMITableLayout.Controls.Add(this.MyWeightLabel, 0, 2);
            this.BMITableLayout.Controls.Add(this.HeightInputTextBox, 1, 1);
            this.BMITableLayout.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMITableLayout.Controls.Add(this.ImerialRadioButton, 0, 0);
            this.BMITableLayout.Location = new System.Drawing.Point(4, 34);
            this.BMITableLayout.Name = "BMITableLayout";
            this.BMITableLayout.RowCount = 3;
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayout.Size = new System.Drawing.Size(298, 206);
            this.BMITableLayout.TabIndex = 0;
            this.BMITableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(152, 16);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(143, 35);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 86);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(143, 31);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 155);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(143, 31);
            this.MyWeightLabel.TabIndex = 3;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // HeightInputTextBox
            // 
            this.HeightInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInputTextBox.Location = new System.Drawing.Point(152, 83);
            this.HeightInputTextBox.Name = "HeightInputTextBox";
            this.HeightInputTextBox.Size = new System.Drawing.Size(143, 38);
            this.HeightInputTextBox.TabIndex = 4;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(152, 152);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(143, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // ImerialRadioButton
            // 
            this.ImerialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImerialRadioButton.AutoSize = true;
            this.ImerialRadioButton.Location = new System.Drawing.Point(3, 16);
            this.ImerialRadioButton.Name = "ImerialRadioButton";
            this.ImerialRadioButton.Size = new System.Drawing.Size(143, 35);
            this.ImerialRadioButton.TabIndex = 0;
            this.ImerialRadioButton.TabStop = true;
            this.ImerialRadioButton.Text = "Imperial";
            this.ImerialRadioButton.UseVisualStyleBackColor = true;
            this.ImerialRadioButton.CheckedChanged += new System.EventHandler(this.ImerialRadioButton_CheckedChanged);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(63, 293);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(173, 38);
            this.BMITextBox.TabIndex = 1;
            this.BMITextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(39, 246);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(210, 41);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIResultsTextBox
            // 
            this.BMIResultsTextBox.Enabled = false;
            this.BMIResultsTextBox.Location = new System.Drawing.Point(32, 349);
            this.BMIResultsTextBox.Multiline = true;
            this.BMIResultsTextBox.Name = "BMIResultsTextBox";
            this.BMIResultsTextBox.Size = new System.Drawing.Size(223, 87);
            this.BMIResultsTextBox.TabIndex = 3;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(304, 448);
            this.Controls.Add(this.BMIResultsTextBox);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.BMITableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.BMITableLayout.ResumeLayout(false);
            this.BMITableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayout;
        private System.Windows.Forms.RadioButton ImerialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox HeightInputTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIResultsTextBox;
    }
}

