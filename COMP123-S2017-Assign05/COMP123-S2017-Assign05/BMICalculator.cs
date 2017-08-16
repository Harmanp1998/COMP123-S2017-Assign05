using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Harmanpreet Singh
 * StudentID : 300931446
 * Date: August 4,2017
 * Description: BMI Calculator
 * Version 0.3: Reset button functional
 */
namespace COMP123_S2017_Assign05
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "m";
            WeightUnitLabel.Text = "kg";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ImerialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "inches";
            WeightUnitLabel.Text = "pounds";
        }

        private void HeightUnitLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightInputTextBox.Text = "";
            WeightTextBox.Text = "";
            BMITextBox.Text = "";
            BMIResultsTextBox.Text = "";
        }

        private void HeightInputTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
