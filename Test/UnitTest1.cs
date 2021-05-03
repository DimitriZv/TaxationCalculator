using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Library;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "10.50";
            string expectResult = "Your Income after $0.00 Tax is $10.50";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "10000";
            string expectResult = "Your Income after $0.00 Tax is $10000.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string input = "20000";
            string expectResult = "Your Income after $342.00 Tax is $19658.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string input = "45000";
            string expectResult = "Your Income after $6172.00 Tax is $38828.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string input = "151111";
            string expectResult = "Your Income after $43543.07 Tax is $107567.93";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string input = "199955.55";
            string expectResult = "Your Income after $63212.00 Tax is $136743.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string input = "0";
            string expectResult = "Your Income after $0.00 Tax is $0.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string input = "18200";
            string expectResult = "Your Income after $0.00 Tax is $18200.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string input = "37000";
            string expectResult = "Your Income after $3572.00 Tax is $33428.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string input = "37001";
            string expectResult = "Your Income after $3572.33 Tax is $33428.68";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string input = "abc";
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string input = "";
            string expectResult = "Error – Please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string input = " ";
            string expectResult = "Error – Please enter a value";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string input = "-100";
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(input);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
