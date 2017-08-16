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
 * Version 0.4: Implemented BMI Calculate
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
            if (ImperialRadioButton.Checked == true)
            {
                double height = double.Parse(HeightInputTextBox.Text);
                double Weight = double.Parse(WeightTextBox.Text);
                double BMI;
                BMI = (Weight * 703) / (height * height);
                BMITextBox.Text = BMI.ToString();
                if (BMI <= 18.5)
                {
                    BMIResultsTextBox.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI <= 24.9)
                {
                    BMIResultsTextBox.Text = "Normal";
                }
                else if (BMI > 25 && BMI <= 29.9)
                {
                    BMIResultsTextBox.Text = "Overweight";
                }
                else if (BMI >= 30)
                {
                    BMIResultsTextBox.Text = "Obese";
                }
            }
            if (MetricRadioButton.Checked == true)
            {
                double height = double.Parse(HeightInputTextBox.Text);
                double Weight = double.Parse(WeightTextBox.Text);
                double BMI;
                BMI = (Weight) / (height * height);
                BMITextBox.Text = BMI.ToString();
                if (BMI <= 18.5)
                {
                    BMIResultsTextBox.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI <= 24.9)
                {
                    BMIResultsTextBox.Text = "Normal";
                }
                else if (BMI > 25 && BMI <= 29.9)
                {
                    BMIResultsTextBox.Text = "Overweight";
                }
                else if (BMI >= 30)
                {
                    BMIResultsTextBox.Text = "Obese";
                }
            }
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
