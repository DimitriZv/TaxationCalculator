using Library;
using System;
using System.Globalization;

namespace Library
{
    public class TestStrings
    {
        public static void PrintConsole(string methodName, string actualResult, string expectResult, bool resultBool)
        {
            string resultShow = "";
            
            if (resultBool == true)
            {
                resultShow = "Test passed";
            }
            else
            {
                resultShow = "Test failed";
            }
            Console.WriteLine("Manual Test Case " + methodName + ": " + resultShow);
            Console.WriteLine("    Expected output: " + expectResult);
            Console.WriteLine("    Actual output: " + actualResult);
        }

        public static bool TestMethod1()
        {
            //spet 1 - Initialize
            string inputAmount = "abc";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            bool resultBool = expectResult.Equals(actualResult);
            PrintConsole("1", actualResult, expectResult, resultBool);
            return resultBool;
        }

        public static bool TestMethod2()
        {
            //spet 1 - Initialize
            string inputAmount = "";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            bool resultBool = expectResult.Equals(actualResult);

            PrintConsole("2", actualResult, expectResult, resultBool);
            return resultBool;
        }

        public static bool TestMethod3()
        {
            //spet 1 - Initialize
            string inputAmount = " ";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            bool resultBool = expectResult.Equals(actualResult);

            PrintConsole("3", actualResult, expectResult, resultBool);
            return resultBool;
        }

        public static bool TestMethod4()
        {
            //spet 1 - Initialize
            string inputAmount = "-100";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            bool resultBool = expectResult.Equals(actualResult);

            PrintConsole("4", actualResult, expectResult, resultBool);
            return resultBool;
        }

        public static bool TestMethod5()
        {
            //spet 1 - Initialize
            string inputAmount = "10000";
            string inputYear = "";
            bool status = true;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            bool resultBool = expectResult.Equals(actualResult);

            PrintConsole("5", actualResult, expectResult, resultBool);
            return resultBool;
        }
    }
}
