namespace COMP123_S2017_Assign05
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
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIResultsTextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightInputTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.BMITableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMITableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(50, 338);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(182, 38);
            this.BMITextBox.TabIndex = 1;
            this.BMITextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(32, 246);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(203, 41);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIResultsTextBox
            // 
            this.BMIResultsTextBox.Enabled = false;
            this.BMIResultsTextBox.Location = new System.Drawing.Point(32, 382);
            this.BMIResultsTextBox.Multiline = true;
            this.BMIResultsTextBox.Name = "BMIResultsTextBox";
            this.BMIResultsTextBox.Size = new System.Drawing.Size(223, 54);
            this.BMIResultsTextBox.TabIndex = 3;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(252, 158);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(55, 20);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "inches";
            this.HeightUnitLabel.Click += new System.EventHandler(this.HeightUnitLabel_Click);
            // 
            // HeightInputTextBox
            // 
            this.HeightInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInputTextBox.Location = new System.Drawing.Point(152, 83);
            this.HeightInputTextBox.Name = "HeightInputTextBox";
            this.HeightInputTextBox.Size = new System.Drawing.Size(144, 38);
            this.HeightInputTextBox.TabIndex = 4;
            this.HeightInputTextBox.TextChanged += new System.EventHandler(this.HeightInputTextBox_TextChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 14);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(143, 35);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImerialRadioButton_CheckedChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(152, 154);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(144, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 158);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(143, 31);
            this.MyWeightLabel.TabIndex = 3;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 87);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(143, 31);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(152, 14);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(144, 35);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // BMITableLayout
            // 
            this.BMITableLayout.ColumnCount = 2;
            this.BMITableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayout.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMITableLayout.Controls.Add(this.MyHeightLabel, 0, 1);
            this.BMITableLayout.Controls.Add(this.MyWeightLabel, 0, 2);
            this.BMITableLayout.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMITableLayout.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMITableLayout.Controls.Add(this.HeightInputTextBox, 1, 1);
            this.BMITableLayout.Location = new System.Drawing.Point(4, 34);
            this.BMITableLayout.Name = "BMITableLayout";
            this.BMITableLayout.RowCount = 3;
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.BMITableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.BMITableLayout.Size = new System.Drawing.Size(299, 206);
            this.BMITableLayout.TabIndex = 0;
            this.BMITableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(241, 232);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(62, 20);
            this.WeightUnitLabel.TabIndex = 5;
            this.WeightUnitLabel.Text = "pounds";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(87, 293);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 39);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(304, 448);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.HeightUnitLabel);
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
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIResultsTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.TextBox HeightInputTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TableLayoutPanel BMITableLayout;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

