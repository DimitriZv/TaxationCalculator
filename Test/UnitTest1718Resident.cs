using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Library;

namespace Test {   
[TestClass]
// resident 2017-2018 test cases
public class UnitTest1718Resident
    {
        private Random random = new Random();
        private string inputYear = "2017-18";
        private bool status = true;
        private int[] ranges = { 0, 18200, 37000, 87000, 180000 };
        static void Main()
        {
            UnitTest1718Resident unitTest = new UnitTest1718Resident();
            double rate = unitTest.TestMethod();
            if(rate < 1)
            {
                Console.WriteLine("Fail the test");
            }
            else
            {
                Console.WriteLine("Pass the test");
            }
        }
        [TestMethod]
        //method for generating random values
        public double GenerateValues(int minValue, int maxValue)
        {
            return random.Next(minValue,maxValue);
        }
        //generate different ranges of values and then test all of them
        [TestMethod]
        public double TestMethod()
        {
            //count correct answers and calculate correct rate
            int correctAnswer = 0;

            Console.WriteLine("Start Automation Testing Tool...");
            Console.WriteLine("YEAR : "+ inputYear+ "     STATUS : resident");
            //step 1 : generate random testing values
            for (int index = 0;index < ranges.Length;index++)
            {
                Console.WriteLine("Test case "+index+"---");
                double testAmount;
                if (index == 0)
                {
                    testAmount = 0;
                }
                else if(index == ranges.Length - 1)
                {
                    testAmount = GenerateValues(ranges[index] + 1,Int32.MaxValue);
                }
                else
                {
                    testAmount = GenerateValues(ranges[index-1] + 1,ranges[index]);
                }
                Console.WriteLine("Test case value: " + testAmount);
                //get expected values and the values from the tax calculator
                double expectedAmount = expectedResult(index, testAmount);
                Console.WriteLine("Expected result value: " + expectedAmount);
                double taxAmount = Calculate.taxByYear(testAmount, Calculate.inputYearIndex(inputYear), status);
                Console.WriteLine("Value by tax calculator: " + taxAmount);
                //step 3 - Assert
                if (expectedAmount == taxAmount)
                {
                    correctAnswer += 1;
                }
            }
            double correctRate = correctAnswer / ranges.Length;
            Console.WriteLine("Correct rate of testing cases: " + correctRate * 100 + "%");
            return correctRate;
        }
        //get the expected result
        public double expectedResult(int indexValue, double testAmount)
        {
            switch(indexValue)
            {
                case 0:
                    return 0;
                case 1:
                    return (testAmount - ranges[indexValue]) * 0.19;
                case 2:
                    return ((testAmount - ranges[indexValue]) * 0.325) + 3572;
                case 3:
                    return ((testAmount - ranges[indexValue]) * 0.37) + 19822;
                case 4:
                    return ((testAmount - ranges[indexValue]) * 0.45) + 54232;
                default:
                    return 0;
            }
        }
    }
}
