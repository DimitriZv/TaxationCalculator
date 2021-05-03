using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Library;

namespace Test
{
    //"2019-20"  "2018-19"   "2017-18"
[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "10.50";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $0.00 Tax is $10.50";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = "10000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $0.00 Tax is $10,000.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string inputAmount = "20000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $342.00 Tax is $19,658.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string inputAmount = "45000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $6,172.00 Tax is $38,828.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string inputAmount = "151111";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $43,543.07 Tax is $107,567.93";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string inputAmount = "199955.55";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $63,212.00 Tax is $136,743.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string inputAmount = "0";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $0.00 Tax is $0.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string inputAmount = "18200";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $0.00 Tax is $18,200.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string inputAmount = "37000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $3,572.00 Tax is $33,428.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string inputAmount = "37001";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Your Income after $3,572.33 Tax is $33,428.68";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string inputAmount = "abc";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error – Please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = " ";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error – Please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "-100";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
