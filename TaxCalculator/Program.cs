using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace TaxCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //start the testing before running the tax calculator
            TestTool testTool = new TestTool();
            double rate = testTool.printTest();
            if (rate < 1)
            {
                Console.WriteLine("Fail the test");
            }
            else
            {
                Console.WriteLine("Pass the test");
                //if pass the test, then the tax calculator will be able to run
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
