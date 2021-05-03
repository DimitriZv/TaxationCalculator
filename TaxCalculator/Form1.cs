using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxCalculator;
using Library; //our program Library (not from .NET)
using System.Globalization;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tntCalculate_Click(object sender, EventArgs e)
        {
            string inputAmount = (txtInput.Text);
            string inputYear = (yearInput.Text);
            bool residentFull = fullYearResident.Checked; //bool resedentNotFull = notFullYearResident.Checked;

            string result = Calculate.Calculating(inputAmount, inputYear, residentFull);
            
            lbl_result.Text = result; //MessageBox.Show(result);
        }

        private void fullYearResident_CheckedChanged(object sender, EventArgs e)
        {
            notFullYearResident.Checked = !fullYearResident.Checked;
        }

        private void notFullYearResident_CheckedChanged(object sender, EventArgs e)
        {
            fullYearResident.Checked = !notFullYearResident.Checked;
        }
    }
}