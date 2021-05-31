using Library;
using System;
using System.Globalization;

namespace TestStringsMethods
{
    class TestStringsMethods
    {
        public static void PrintConsole(string methodName, string actualResult, string expectResult, bool resultBool)
        {
            string resultShow = "";
            if (resultBool == true)
            { resultShow = "passed"; }
            else { resultShow = "failed"; }

            Console.WriteLine("Manual Test " + methodName + " is: " + resultShow);
            Console.WriteLine("    expected out: " + expectResult);
            Console.WriteLine("    actual out: " + actualResult);
        }

        public static void TestMethod1()
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

            PrintConsole("TestMethod1", actualResult, expectResult, resultBool);
        }

        public static void TestMethod2()
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

            PrintConsole("TestMethod1", actualResult, expectResult, resultBool);
        }

        public static void TestMethod3()
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

            PrintConsole("TestMethod1", actualResult, expectResult, resultBool);
        }

        public static void TestMethod4()
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

            PrintConsole("TestMethod1", actualResult, expectResult, resultBool);
        }

        public static void TestMethod5()
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

            PrintConsole("TestMethod1", actualResult, expectResult, resultBool);
        }
    }
}
