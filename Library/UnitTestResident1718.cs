using System;
using Library;

namespace Library
{   
// resident 2017-2018 test cases
public class UnitTestResident1718
    {
        private Random random = new Random();
        private string inputYear = "2017-18";
        private bool status = true;
        private int[] ranges = { 0, 18200, 37000, 87000, 180000 };

        //method for generating random values
        public double GenerateValues(int minValue, int maxValue)
        {
            return random.Next(minValue,maxValue);
        }
        //generate different ranges of values and then test all of them

        public double TestMethod()
        {
            //count correct answers and calculate correct rate
            double correctAnswer = 0.0;

            Console.WriteLine("Start Automation Testing Tool...");
            Console.WriteLine("YEAR : "+ inputYear+ "     STATUS : resident");
            //step 1 : generate random testing values
            for (int index = 0;index <= ranges.Length;index++)
            {
                Console.WriteLine("Test case "+ (index+1) +"---");
                double testAmount;
                if (index == 0)
                {
                    testAmount = 0;
                }
                else if(index == ranges.Length)
                {
                    testAmount = GenerateValues(ranges[index-1] + 1,Int32.MaxValue);
                }
                else
                {
                    testAmount = GenerateValues(ranges[index-1] + 1,ranges[index]);
                }
                Console.WriteLine("Test case value: " + testAmount);
                //get expected values and the values from the tax calculator
                double expectedAmount = expectedResult(index, testAmount);
                
                //print out the final result
                Console.WriteLine("Expected result value: " + expectedAmount);
                double taxAmount = Calculate.taxByYear(testAmount, Calculate.inputYearIndex(inputYear), status);
                Console.WriteLine("Value by tax calculator: " + taxAmount);
                //step 3 - Assert
                if (expectedAmount == taxAmount)
                {
                    correctAnswer += 1;
                }
            }
            double correctRate = correctAnswer / (ranges.Length + 1);
            Console.WriteLine("The tax calculator got "+correctAnswer+" out of " + (ranges.Length+1) + " correct");
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
                    return 0;
                case 2:
                    return (testAmount - ranges[indexValue-1]) * 0.19;
                case 3:
                    return ((testAmount - ranges[indexValue-1]) * 0.325) + 3572;
                case 4:
                    return ((testAmount - ranges[indexValue-1]) * 0.37) + 19822;
                case 5:
                    return ((testAmount - ranges[indexValue-1]) * 0.45) + 54232;
                default:
                    return 0;
            }
        }
    }
}
