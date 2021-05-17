using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Library;

namespace Test2017_18_Residents       //"2017-18 - Residents"
{
    [TestClass]

    public class UnitTest1
    {
        /*---------------------------- 2017-18 -----------------------------*/
        /*  Tax for Residens    */
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "10.50";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10.50";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10,000.00";
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
            string expectResult = "The estimated tax on your taxable income is $342.00\nYour estimated income after tax is $19,658.00";
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
            string expectResult = "The estimated tax on your taxable income is $6,172.00\nYour estimated income after tax is $38,828.00";
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
            string expectResult = "The estimated tax on your taxable income is $43,543.07\nYour estimated income after tax is $107,567.93";
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
            string expectResult = "The estimated tax on your taxable income is $63,212.00\nYour estimated income after tax is $136,743.55";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $18,200.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string inputAmount = "18201";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.19\nYour estimated income after tax is $18,200.81";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string inputAmount = "37000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.00\nYour estimated income after tax is $33,428.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string inputAmount = "37001";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.33\nYour estimated income after tax is $33,428.68";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "87000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $19,822.00\nYour estimated income after tax is $67,178.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "87001";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $19,822.37\nYour estimated income after tax is $67,178.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,232.00\nYour estimated income after tax is $125,768.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,232.45\nYour estimated income after tax is $125,768.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod16()
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
        public void TestMethod17()
        {
            string inputAmount = "";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod18()
        {
            string inputAmount = " ";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod19()
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
        [TestMethod]
        public void TestMethod20()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = true;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2017-18 for Residents-----------------*/
        /*               Taxes for Non-Residents           */


    }
}
namespace Test2017_18_Non_Residents       //"2017-18 - Non-Residents"
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            string inputAmount = "abc";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = " ";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string inputAmount = "-100";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = false;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string inputAmount = "199955.55";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $71,665.00\nYour estimated income after tax is $128,290.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        
        /*--------------------- Range Tax Groups ---------*/
        [TestMethod]
        public void TestMethod6()
        {
            string inputAmount = "0";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "87000";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $28,275.00\nYour estimated income after tax is $58,725.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "87001";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $28,275.37\nYour estimated income after tax is $58,725.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,685.00\nYour estimated income after tax is $117,315.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2017-18";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,685.45\nYour estimated income after tax is $117,315.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2017-18 for Residents-----------------*/
        /*               Taxes for Non-Residents           */


    }
}

namespace Test2018_19_Residents       //"2018-19 - Residents"
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "10.50";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10.50";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod16()
        {
            string inputAmount = "abc";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod17()
        {
            string inputAmount = "";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod18()
        {
            string inputAmount = " ";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod19()
        {
            string inputAmount = "-100";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod20()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = true;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        
        /*--------------------- Range Tax Groups ---------*/
        /*  Tax for Residens    */
        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = "10000";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10,000.00";
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
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $342.00\nYour estimated income after tax is $19,658.00";
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
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $6,172.00\nYour estimated income after tax is $38,828.00";
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
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $43,408.07\nYour estimated income after tax is $107,702.93";
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
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $63,077.00\nYour estimated income after tax is $136,878.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*------------------------------------------------*/
        [TestMethod]
        public void TestMethod7()
        {
            string inputAmount = "0";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
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
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $18,200.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string inputAmount = "18201";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.19\nYour estimated income after tax is $18,200.81";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string inputAmount = "37000";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.00\nYour estimated income after tax is $33,428.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string inputAmount = "37001";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.33\nYour estimated income after tax is $33,428.68";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "90000";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $20,797.00\nYour estimated income after tax is $69,203.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "90001";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $20,797.37\nYour estimated income after tax is $69,203.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,097.00\nYour estimated income after tax is $125,903.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2018-19";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,097.45\nYour estimated income after tax is $125,903.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2018-19 for Residents-----------------*/
    }
}
namespace Test2018_19_Non_Residents       //"2018-19- Non-Residents"
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            string inputAmount = "abc";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = " ";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string inputAmount = "-100";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = false;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string inputAmount = "199955.55";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $71,530.00\nYour estimated income after tax is $128,425.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        /*--------------------- Range Tax Groups ---------*/
        [TestMethod]
        public void TestMethod6()
        {
            string inputAmount = "0";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "90000";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $29,250.00\nYour estimated income after tax is $60,750.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "90001";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $29,250.37\nYour estimated income after tax is $60,750.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,550.00\nYour estimated income after tax is $117,450.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2018-19";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,550.45\nYour estimated income after tax is $117,450.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2018-19 for Non Residents-----------------*/
    }
}

namespace Test2019_20_Residents       //"2019-20 - Residents"
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "10.50";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10.50";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod16()
        {
            string inputAmount = "abc";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod17()
        {
            string inputAmount = "";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod18()
        {
            string inputAmount = " ";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod19()
        {
            string inputAmount = "-100";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod20()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = true;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        /*--------------------- Range Tax Groups ---------*/
        /*  Tax for Residens    */
        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = "10000";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10,000.00";
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
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $342.00\nYour estimated income after tax is $19,658.00";
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
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $6,172.00\nYour estimated income after tax is $38,828.00";
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
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $43,408.07\nYour estimated income after tax is $107,702.93";
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
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $63,077.00\nYour estimated income after tax is $136,878.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*------------------------------------------------*/
        [TestMethod]
        public void TestMethod7()
        {
            string inputAmount = "0";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
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
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $18,200.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string inputAmount = "18201";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.19\nYour estimated income after tax is $18,200.81";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string inputAmount = "37000";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.00\nYour estimated income after tax is $33,428.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string inputAmount = "37001";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $3,572.33\nYour estimated income after tax is $33,428.68";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "90000";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $20,797.00\nYour estimated income after tax is $69,203.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "90001";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $20,797.37\nYour estimated income after tax is $69,203.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,097.00\nYour estimated income after tax is $125,903.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2019-20";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $54,097.45\nYour estimated income after tax is $125,903.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2019-20 for Residents-----------------*/
    }
}
namespace Test2019_20_Non_Residents       //"2019-20- Non-Residents"
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            string inputAmount = "abc";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "Error - Enter Numbers Only";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string inputAmount = " ";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "Error: Please input an amount.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string inputAmount = "-100";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "Error – value cannot be negative";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string inputAmount = "10000";
            string inputYear = "";
            bool status = false;
            string expectResult = "Error: Please select a year.";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string inputAmount = "199955.55";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $71,530.00\nYour estimated income after tax is $128,425.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        /*--------------------- Range Tax Groups ---------*/
        [TestMethod]
        public void TestMethod6()
        {
            string inputAmount = "0";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string inputAmount = "90000";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $29,250.00\nYour estimated income after tax is $60,750.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string inputAmount = "90001";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $29,250.37\nYour estimated income after tax is $60,750.63";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string inputAmount = "180000";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,550.00\nYour estimated income after tax is $117,450.00";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string inputAmount = "180001";
            string inputYear = "2019-20";
            bool status = false;
            string expectResult = "The estimated tax on your taxable income is $62,550.45\nYour estimated income after tax is $117,450.55";
            string actualResult;

            //step 2 - Act
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //step 3 - Assert
            Assert.AreEqual(expectResult, actualResult);
        }
        /*--------------------------End 2019-20 for Non Residents-----------------*/
    }
}

namespace Test       //"2019-20"   "2018-19"   "2017-18"
{
[TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputAmount = "10.50";
            string inputYear = "2017-18";
            bool status = true;
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10.50";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $10,000.00";
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
            string expectResult = "The estimated tax on your taxable income is $342.00\nYour estimated income after tax is $19,658.00";
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
            string expectResult = "The estimated tax on your taxable income is $6,172.00\nYour estimated income after tax is $38,828.00";
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
            string expectResult = "The estimated tax on your taxable income is $43,543.07\nYour estimated income after tax is $107,567.93";
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
            string expectResult = "The estimated tax on your taxable income is $63,212.00\nYour estimated income after tax is $136,743.55";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $0.00";
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
            string expectResult = "The estimated tax on your taxable income is $0.00\nYour estimated income after tax is $18,200.00";
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
            string expectResult = "The estimated tax on your taxable income is $3,572.00\nYour estimated income after tax is $33,428.00";
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
            string expectResult = "The estimated tax on your taxable income is $3,572.33\nYour estimated income after tax is $33,428.68";
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
            string expectResult = "Error: Please input an amount.";
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
            string expectResult = "Error: Please input an amount.";
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

        [TestMethod]
        public void TestMethod15()    //2017-2018 non-resident 0-87,000 bracket    *****this uses random input so it can be called in a loop to generate tests (NOT YET IMPLEMENTED)  
        {
            Random rnd = new Random();
            int randInputAmount = rnd.Next(0, 87001);  //create number between 0 and 87000 (not inclusive)

            string inputAmount = randInputAmount.ToString();  //convert to string, as calculationg method only accepts string

            string inputYear = "2017-18";
            bool status = false;    //residency status

            double taxPayable = randInputAmount * 0.325;    //calculating the amount of tax payable
            double afterTaxIncome = randInputAmount - taxPayable;

            string taxPayableString = Calculate.currenceView(taxPayable);
            string afterTaxIncomeString = Calculate.currenceView(afterTaxIncome);

            string expectResult = "The estimated tax on your taxable income is $" + taxPayableString + "\nYour estimated income after tax is $" + afterTaxIncomeString;
            string actualResult;

            //generate actual resluts for comparison
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //compare expected vs actual results
            Assert.AreEqual(expectResult, actualResult);
        }


        [TestMethod]
        public void TestMethod16()    //2017-2018 non-resident 87001-180000 bracket    *****this uses random input so it can be called in a loop to generate tests (NOT YET IMPLEMENTED)  
        {
            Random rnd = new Random();
            int randInputAmount = rnd.Next(87001, 180001);  //create number between 87001 and 180000 (not inclusive)

            string inputAmount = randInputAmount.ToString();  //convert to string, as calculationg method only accepts string

            string inputYear = "2017-18";
            bool status = false;    //residency status

            double taxPayable = ((randInputAmount -87000)* 0.37) + 28275;    //calculating the amount of tax payable
            double afterTaxIncome = randInputAmount - taxPayable;

            string taxPayableString = Calculate.currenceView(taxPayable);
            string afterTaxIncomeString = Calculate.currenceView(afterTaxIncome);

            string expectResult = "The estimated tax on your taxable income is $" + taxPayableString + "\nYour estimated income after tax is $" + afterTaxIncomeString;
            string actualResult;

            //generate actual resluts for comparison
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //compare expected vs actual results
            Assert.AreEqual(expectResult, actualResult);
        }


        [TestMethod]             
        public void TestMethod17()    //2017-2018 non-resident 180001 and up bracket  *****this uses random input so it can be called in a loop to generate tests (NOT YET IMPLEMENTED)   
        {
            Random rnd = new Random();
            int randInputAmount = rnd.Next(180001, 100000001);  //create number between 180,001 and 100,000,000 (not inclusive) i just chose 100mil as i didnt want to go to high

            string inputAmount = randInputAmount.ToString();  //convert to string, as calculationg method only accepts string

            string inputYear = "2017-18";
            bool status = false;    //residency status

            double taxPayable = ((randInputAmount - 180000) * 0.45) + 62685;    //calculating the amount of tax payable
            double afterTaxIncome = randInputAmount - taxPayable;

            string taxPayableString = Calculate.currenceView(taxPayable);
            string afterTaxIncomeString = Calculate.currenceView(afterTaxIncome);

            string expectResult = "The estimated tax on your taxable income is $" + taxPayableString + "\nYour estimated income after tax is $" + afterTaxIncomeString;
            string actualResult;

            //generate actual resluts for comparison
            actualResult = Calculate.Calculating(inputAmount, inputYear, status);

            //compare expected vs actual results
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
