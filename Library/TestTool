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
			Console.WriteLine("Start Automation Testing Tool...");
			Console.WriteLine("Enter 'Y' if you wish to see full test result output");
			Console.WriteLine("Enter 'N' if you only wish to see failed test result output");
			Console.Write("Enter your choice: ");
			string choice = Console.ReadLine();
			//run different test case classes
			UnitTestResident1718 unitTest = new UnitTestResident1718();
			Unit unit = unitTest.TestMethod();
			//calculate total cases
			totalTestCases += unit.getTotalTest();
			totalPassedTestCases += unit.getPassedTest();
			units.Add(unit);

			Console.WriteLine("\n=================================================================================================");
			Console.WriteLine("Total tests executed: " + totalTestCases);
			Console.WriteLine("Passed tests: " + totalPassedTestCases);
			Console.WriteLine("Failed tests: " + (totalTestCases - totalPassedTestCases));
			double successRate = totalPassedTestCases / totalTestCases;
			Console.WriteLine("Sucess rate: " + successRate * 100 + "%");

			if(successRate == 1)
            {
				Console.WriteLine("No failed test case");
			}
			else //print out the incorrect records
			{
				int totalIndex = 1;
				for (int i = 0; i < units.Count; i++)
				{
					Console.WriteLine("YEAR : " + units[i].getYear() + "     STATUS : " + units[i].getStatus());
					if (units[i].getFalseLength() != 0)
					{
						for (int index = 0; index < units[i].getFalseLength(); index++)
						{
							Console.WriteLine("Failed Result " + totalIndex + ":");
							Console.WriteLine("The tested income is $" + units[i].getFIncomeValue(index));
							Console.WriteLine(units[i].getFExpectedValue(index));
							Console.WriteLine(units[i].getFActualValue(index));
							Console.WriteLine();
							totalIndex += 1;
						}
					}
				}
			}
			Console.WriteLine("=================================================================================================");

			if(choice.Equals("Y")) //print out the incorrect records
			{
				Console.WriteLine("Correct Test Cases OutPut Results:");
				int allIndex = 1;
				for (int i = 0; i < units.Count; i++)
				{
					if (units[i].getLength() != 0)
					{
						Console.WriteLine("YEAR : " + units[i].getYear() + "     STATUS : " + units[i].getStatus());
						for (int index = 0; index < units[i].getLength(); index++)
						{
							Console.WriteLine("Test Result " + allIndex + ":");
							Console.WriteLine("The tested income is $" + units[i].getIncomeValue(index));
							Console.WriteLine(units[i].getExpectedValue(index));
							Console.WriteLine(units[i].getActualValue(index));
							Console.WriteLine();
							allIndex += 1;
						}
					}
				}
			}
			
			return successRate;
        }
    }
}
