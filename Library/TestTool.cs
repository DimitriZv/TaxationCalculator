using System;
using Library;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class TestTool
    {
		double totalTestCases = 0;
		double totalPassedTestCases = 0;
		private List<Unit> units = new List<Unit>();

		public double printTest()
        {
			//start the testing tool
			Console.WriteLine("Start Manual Test Cases...");
			checkManualTestCases(TestStrings.TestMethod1());
			checkManualTestCases(TestStrings.TestMethod2());
			checkManualTestCases(TestStrings.TestMethod3());
			checkManualTestCases(TestStrings.TestMethod4());
			checkManualTestCases(TestStrings.TestMethod5());

			Console.WriteLine("\nStart Automation Testing Tool...");

			//run different test case classes based on the year and residency status
			UnitTestResident1718 unitTest1 = new UnitTestResident1718();
			Unit unit1 = unitTest1.TestMethod();
			calculateCases(unit1);

			UnitTestResident1819 unitTest2 = new UnitTestResident1819();
			Unit unit2 = unitTest2.TestMethod();
			calculateCases(unit2);

			UnitTestResident1920 unitTest3 = new UnitTestResident1920();
			Unit unit3 = unitTest3.TestMethod();
			calculateCases(unit3);
			
			UnitTestNonResident1718 unitTest4 = new UnitTestNonResident1718();
			Unit unit4 = unitTest4.TestMethod();
			calculateCases(unit4);

			UnitTestNonResident1819 unitTest5 = new UnitTestNonResident1819();
			Unit unit5 = unitTest5.TestMethod();
			calculateCases(unit5);
			
			UnitTestNonResident1920 unitTest6 = new UnitTestNonResident1920();
			Unit unit6 = unitTest6.TestMethod();
			calculateCases(unit6);

			double successRate = totalPassedTestCases / totalTestCases;
			Console.WriteLine("---------------------------------------------------");
			
			//print out the correct records
			Console.WriteLine("Correct Test Cases OutPut Results:");
			int allIndex = 1;
			for (int i = 0; i < units.Count; i++)
			{
				if (units[i].getLength() != 0)
				{
					Console.WriteLine("YEAR : " + units[i].getYear() + "     STATUS : " + units[i].getStatus());
					for (int index = 0; index < units[i].getLength(); index++)
					{
						Console.WriteLine("Test Case " + allIndex + ":");
						Console.WriteLine("The tested income is $" + units[i].getIncomeValue(index));
						Console.WriteLine(units[i].getExpectedValue(index));
						Console.WriteLine(units[i].getActualValue(index));
						Console.WriteLine();
						allIndex += 1;
					}
				}
			}
			Console.WriteLine("\n=================================================================================================");
			Console.WriteLine("Total tests executed: " + totalTestCases);
			Console.WriteLine("Passed tests: " + totalPassedTestCases);
			Console.WriteLine("Failed tests: " + (totalTestCases - totalPassedTestCases));
			Console.WriteLine("Sucess rate: " + successRate * 100 + "%");
			Console.WriteLine("=================================================================================================");
			if (successRate == 1)
			{
				Console.WriteLine("No failed test case");
			}
			else //print out the incorrect records
			{
				Console.WriteLine("Output of the failed test cases:");
				int totalIndex = 1;
				for (int i = 0; i < units.Count; i++)
				{
					Console.WriteLine("YEAR : " + units[i].getYear() + "     STATUS : " + units[i].getStatus());
					if (units[i].getFalseLength() != 0)
					{
						for (int index = 0; index < units[i].getFalseLength(); index++)
						{
							Console.WriteLine("Failed Test Case " + totalIndex + ":");
							Console.WriteLine("The tested income is $" + units[i].getFIncomeValue(index));
							Console.WriteLine(units[i].getFExpectedValue(index));
							Console.WriteLine(units[i].getFActualValue(index));
							Console.WriteLine();
							totalIndex += 1;
						}
					}
				}
			}
			return successRate;
        }
		public void calculateCases(Unit unit) //calculate total cases
		{
			totalTestCases += unit.getTotalTest();
			totalPassedTestCases += unit.getPassedTest();
			units.Add(unit);
		}
		public void checkManualTestCases(bool isPassed)
        {
			totalTestCases += 1;
			if (isPassed == true)
            {
				totalPassedTestCases += 1;
			}
        }
    }
}
