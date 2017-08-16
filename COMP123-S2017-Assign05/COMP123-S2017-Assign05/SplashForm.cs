using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_Assign05
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GreeetingLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "source.gif";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculator = new BMICalculatorForm();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
