using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Harmanpreet Singh
 * StudentID : 300931446
 * Date: August 4,2017
 * Description: BMI Calculator
 * Version 0.1: Created Project Files
 */
namespace COMP123_S2017_Assign05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
