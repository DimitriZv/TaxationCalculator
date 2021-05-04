using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Calculate
    {
        public static string Calculating(string amount, string inputYear, bool resident)
        {
            double inputDoubleAmount;
            int inputIntYear = inputYearIndex(inputYear);
            bool successAmount = double.TryParse(amount, out inputDoubleAmount); //bool successYear = int.TryParse(inputYear, out inputIntYear);
            
            if (isEmpty(amount))
            {
                return "Error: Please input an amount.";
            }

            if (isEmpty(inputYear))
            {
                return "Error: Please select a year.";
            }

            if (successAmount)
            {
                if (inputDoubleAmount < 0)
                {
                    return "Error – value cannot be negative";
                }
                else
                {
                    double result = taxByYear(inputDoubleAmount, inputIntYear, resident);
                    double inputCurrent = after(inputDoubleAmount);
                    //string msg = "Your Income after " + "$" + (result.ToString("0.00")) + " Tax is $" + (input1 - result).ToString("0.00");
                    //string msg = "Your Income after " + "$" + currenceView(result) + " Tax is $" + currenceView(inputCurrent- result);
                    string msg = "The estimated tax on your taxable income is " + "$" + currenceView(result) + "\nYour estimated income after tax is $" + currenceView(inputCurrent- result);
                    return msg;
                }
            }
            else
            {
                return "Error - Enter Numbers Only";
            }
        }

        public static string currenceView(double amount)
        {
            var nfi = new NumberFormatInfo { NumberDecimalSeparator = ".", NumberGroupSeparator = "," };
            string res = amount.ToString("#,##0.00", nfi); //result will always be 1.234.567,00
            return res;
        }

        public static double taxByYear(double input, int year, bool status)
        {
            if(status == true)
            {
                switch (year)
                {
                    case 0: //2019-20
                        {
                            if (input >= 0 && input <= 18200)
                            {
                                return (0);
                            }
                            else if (input >= 18201 && input <= 37000)
                            {
                                return (((input - 18200) * 0.19));
                            }
                            else if (input >= 37001 && input <= 90000)
                            {
                                return (((input - 37000) * 0.325) + 3572);
                            }
                            else if (input >= 90001 && input <= 180000)
                            {
                                return (((input - 90000) * 0.37) + 20797);
                            }
                            else if (input >= 180001)
                            {
                                return (((input - 180000) * 0.45) + 54097);
                            }
                            else
                            {
                                return (0);
                            }
                        }
                    case 1: //2018-19
                        {
                            if (input >= 0 && input <= 18200)
                            {
                                return (0);
                            }
                            else if (input >= 18201 && input <= 37000)
                            {
                                return (((input - 18200) * 0.19));
                            }
                            else if (input >= 37001 && input <= 90000)
                            {
                                return (((input - 37000) * 0.325) + 3572);
                            }
                            else if (input >= 90001 && input <= 180000)
                            {
                                return (((input - 90000) * 0.37) + 20797);
                            }
                            else if (input >= 180001)
                            {
                                return (((input - 180000) * 0.45) + 54097);
                            }
                            else
                            {
                                return (0);
                            }
                        }
                    //case TaxYears.Year2017_18: //2017-18
                    case 2:
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
                    default:
                        {
                            return 0;
                        }
                }
            }
            else
            {
                switch (year)
                {
                    case 0: //2019-20
                        {
                            if (input >= 0 && input <= 90000)
                            {
                                return (input * 0.325);
                            }
                            else if (input >= 90001 && input <= 180000)
                            {
                                return (((input - 90000) * 0.37) + 29250);
                            }
                            else if (input >= 180001)
                            {
                                return (((input - 180000) * 0.45) + 62550);
                            }
                            else
                            {
                                return (0);
                            }
                        }
                    case 1: //2018-19
                        {
                            if (input >= 0 && input <= 90000)
                            {
                                return (input * 0.325);
                            }
                            else if (input >= 90001 && input <= 180000)
                            {
                                return (((input - 90000) * 0.37) + 29250);
                            }
                            else if (input >= 180001)
                            {
                                return (((input - 180000) * 0.45) + 62550);
                            }
                            else
                            {
                                return (0);
                            }
                        }
                    //case TaxYears.Year2017_18: //2017-18
                    case 2:
                        {
                            if (input >= 0 && input <= 87000)
                            {
                                return (input * 0.325);
                            }
                            else if (input >= 87001 && input <= 180000)
                            {
                                return (((input - 87000) * 0.37) + 28275);
                            }
                            else if (input >= 180001)
                            {
                                return (((input - 180000) * 0.45) + 62685);
                            }
                            else
                            {
                                return (0);
                            }
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
        }
        
        public static int inputYearIndex(string s)
        {
            if (s.Equals("2019-20")) { return 0; }
            else if (s.Equals("2018-19")) { return 1; }
            else if (s.Equals("2017-18")) { return 2; }
            else { return 0; }
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
