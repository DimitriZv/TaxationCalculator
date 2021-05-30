using System;
using Library;
using System.Collections;

namespace Library
{
    public class Unit
    {
		private int totalTest;
		private double passedTest;
		private string status;
		private string year;
		private ArrayList expectedValues = new ArrayList();
		private ArrayList actualValues = new ArrayList();
		private ArrayList incomeValues = new ArrayList();
		private ArrayList fExpectedValues = new ArrayList();
		private ArrayList fActualValues = new ArrayList();
		private ArrayList fIncomeValues = new ArrayList();

		//set all the values
		public void setTotalTest(int totalTestCases)
        {
			this.totalTest = totalTestCases;
		}
		public void setPassedTest(double totalPassedTest)
		{
			this.passedTest = totalPassedTest;
		}
		public void setStatus(string currentStatus)
        {
			this.status = currentStatus;
		}
		public void setYear(string chosenYear)
        {
			this.year = chosenYear;
		}
		public void addExpectedValues(string expectedValue)
        {
			this.expectedValues.Add(expectedValue);
        }
		public void addActualValues(string actualValue)
        {
			this.actualValues.Add(actualValue);
        }
		public void addIncomeValues(double income)
		{
			this.incomeValues.Add(income);
		}
		public void addFIncomeValues(double fIncome)
		{
			this.fIncomeValues.Add(fIncome);
		}
		public void addFExpectedValues(string fExpectedValue)
		{
			this.fExpectedValues.Add(fExpectedValue);
		}
		public void addFActualValues(string fActualValue)
		{
			this.fActualValues.Add(fActualValue);
		}

		//get all the values
		public int getTotalTest()
        {
			return this.totalTest;
        }
		public double getPassedTest()
        {
			return this.passedTest;
        }
		public string getStatus()
        {
			return this.status;
        }
		public string getYear()
        {
			return this.year;
        }
		public object getExpectedValue(int index)
        {
			return this.expectedValues[index];
        }
		public object getActualValue(int index)
        {
			return this.actualValues[index];
        }
		public object getIncomeValue(int index)
		{
			return this.incomeValues[index];
		}
		public object getFExpectedValue(int index)
		{
			return this.fExpectedValues[index];
		}
		public object getFActualValue(int index)
		{
			return this.fActualValues[index];
		}
		public object getFIncomeValue(int index)
		{
			return this.fIncomeValues[index];
		}
		public int getFalseLength()
        {
			return this.fActualValues.Count;
        }
		public int getLength()
		{
			return this.expectedValues.Count;
		}
	}
}
