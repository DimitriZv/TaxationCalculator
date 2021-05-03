using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public static class Calculate
    {
        public static string Calculating(string input)
        {
            double inputDouble;
            bool success = double.TryParse(input, out inputDouble);

            if (isEmpty(input)) return "Error – Please enter a value";

            if (success)
            {
                if (inputDouble < 0)
                {
                    return "Error – value cannot be negative";
                }
                else
                {
                    double result = tax(inputDouble);
                    double input1 = after(inputDouble);
                    //string msg = ("$" + result.ToString("0.00")) + " Tax is $" + (input1 - result).ToString("0.00");
                    string msg = "Your Income after " + "$" + (result.ToString("0.00")) + " Tax is $" + (input1 - result).ToString("0.00");
                    return msg;
                }
            }
            else
            {
                return "Error - Enter Numbers Only";
            }
        }

        public static double tax(double input)
        {
            if (input >= 0 && input <= 18200)
            {
                return (0);
            }
            else if (input >= 18201 && input <= 37000)
            {
                return (((input - 18200) * 0.19));
            }
            else if (input >= 37001 && input <= 87000)
            {
                return (((input - 37000) * 0.325) + 3572);
            }
            else if (input >= 87001 && input <= 180000)
            {
                return (((input - 87000) * 0.37) + 19822);
            }
            else if (input >= 180001)
            {
                return (((input - 180000) * 0.45) + 54232);
            }
            else
            {
                return (0);
            }
        }

        public static double after(double input1)
        {
            return input1;
        }

        private static bool isEmpty(string input)
        {
            if (input == null || input.Trim() == "")
            {
                return true;
            }
            return false;
        }
    }
}
