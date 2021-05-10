using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        //the following test cases are for 2018-2019 residents
        //4a to 4e
        //currently uses visual studio testing tool library and isn't looped
        [TestMethod]
        public void TestCase4a()
        {
            //test case 4)a
            Random rnd = new Random();
            int randomInt = rnd.Next(0, 18200);

            string inputAmount = randomInt.ToString(); //input only accepts strings
            //string inputAmount = "10.50";
            string inputYear = "2018-19";
            bool status = true;
            String expectedString = Calculate.currenceView(randomInt); //convert int to formatted number value
            string expectResult = $"The estimated tax on your taxable income is $0.00\nYour estimated income after tax is ${expectedString}";
            string actualResult;
            Calculate.currenceView(randomInt);

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestCase4b()
        {
            //test case 4)b
            Random rnd = new Random();
            int randomInt = rnd.Next(18201, 37000);

            string inputAmount = randomInt.ToString(); //input only accepts strings
            string inputYear = "2018-19";
            bool status = true;
            double expecteddouble = ((randomInt - 18200) * 0.19);
            String expectedString = Calculate.currenceView(randomInt - expecteddouble); //convert int to formatted number value
            String expectedtaxable = Calculate.currenceView(expecteddouble); //convert double to formatted number value

            string expectResult = $"The estimated tax on your taxable income is ${(expectedtaxable)}\nYour estimated income after tax is ${expectedString}";
 
            string actualResult;
            Calculate.currenceView(randomInt);

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestCase4c()
        {
            //test case 4)c
            Random rnd = new Random();
            int randomInt = rnd.Next(37001, 90000);

            string inputAmount = randomInt.ToString(); //input only accepts strings
            string inputYear = "2018-19";
            bool status = true;
            double expecteddouble = ((randomInt - 37000) * 0.325) + 3572;
            String expectedString = Calculate.currenceView(randomInt - expecteddouble); //convert int to formatted number value
            String expectedtaxable = Calculate.currenceView(expecteddouble); //convert double to formatted number value

            string expectResult = $"The estimated tax on your taxable income is ${(expectedtaxable)}\nYour estimated income after tax is ${expectedString}";

            string actualResult;
            Calculate.currenceView(randomInt);

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestCase4d()
        {
            //test case 4)d
            Random rnd = new Random();
            int randomInt = rnd.Next(90001, 180000);

            string inputAmount = randomInt.ToString(); //input only accepts strings
            string inputYear = "2018-19";
            bool status = true;
            double expecteddouble = ((randomInt - 90000) * 0.37) + 20797;
            String expectedString = Calculate.currenceView(randomInt - expecteddouble); //convert int to formatted number value
            String expectedtaxable = Calculate.currenceView(expecteddouble); //convert double to formatted number value

            string expectResult = $"The estimated tax on your taxable income is ${(expectedtaxable)}\nYour estimated income after tax is ${expectedString}";

            string actualResult;
            Calculate.currenceView(randomInt);

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestCase4e()
        {
            //test case 4)e
            Random rnd = new Random();
            int randomInt = rnd.Next(180001, 500000); //only tests between 180,001 and 500,000

            string inputAmount = randomInt.ToString(); //input only accepts strings
            string inputYear = "2018-19";
            bool status = true;
            double expecteddouble = ((randomInt - 180000) * 0.45) + 54097;
            String expectedString = Calculate.currenceView(randomInt - expecteddouble); //convert int to formatted number value
            String expectedtaxable = Calculate.currenceView(expecteddouble); //convert double to formatted number value

            string expectResult = $"The estimated tax on your taxable income is ${(expectedtaxable)}\nYour estimated income after tax is ${expectedString}";

            string actualResult;
            Calculate.currenceView(randomInt);

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
