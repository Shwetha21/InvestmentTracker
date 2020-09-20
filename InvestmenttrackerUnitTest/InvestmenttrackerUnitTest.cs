using NUnit.Framework;
using ManageAmount;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;
using InvestmentTracker;

namespace InvestmenttrackerUnitTest
{
    public class InvestmenttrackerUnitTest
    {
        private Manager _mymanager; 
        [SetUp] //setup database
        public void Setup()
        {
            _mymanager = new Manager();
        }

        [Test]
        public void TestTotalIncome()
        {
            float itotal = _mymanager.TotalIncome();
            Assert.AreEqual(2860, itotal);
        }

        [Test]
        public void TestTotalExpenditure()
        {
            float etotal = _mymanager.TotalExpenditure();
            Assert.AreEqual(1660, etotal);
        }

        [Test]

        public void TestBalance()
        {
            float mybalance = _mymanager.BalanceCheck();
            Assert.AreEqual(5933, mybalance);
        }


        [Test]
        public void TestMonthlyExpenditure()
        {
            IList collection = (System.Collections.IList)_mymanager.Monthy_Expenditure();
            var output = collection[0].ToString();
            Assert.AreEqual("{ Month = 6, MonthlyExpense = 435.9 }", output);
        }

        [Test]
        public void TestMonthlyIncome()
        {
            IList collection = (System.Collections.IList)_mymanager.Monthly_Income();
            var output = collection[0].ToString();
            Assert.AreEqual("{ Month = 3, MonthlyIncome = 2300 }", output);
        }

        [Test]
        public void DisplayPeopleName()
        {
            List<string> res = _mymanager.DisplayPeopleName();
            Assert.AreEqual("", res);
        }

    }
}