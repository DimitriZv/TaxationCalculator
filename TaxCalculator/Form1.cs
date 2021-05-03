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
            string input = (txtInput.Text);

            string result = Calculate.Calculating(input);

            MessageBox.Show(result);

        }
    }
}
