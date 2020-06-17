using NUnit.Framework;
using ManageAmount;

namespace InvestmenttrackerUnitTest
{
    public class InvestmenttrackerUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTotalIncome()
        {
            Manager _mymanager = new Manager();
            float itotal = _mymanager.TotalIncome();
            Assert.AreEqual(2860, itotal);
        }

        [Test]
        public void TestTotalExpenditure()
        {
            Manager _mymanager = new Manager();
            float etotal = _mymanager.TotalExpenditure();
            Assert.AreEqual(1660, etotal);
        }

        [Test]

        public void TestBalance()
        {
            Manager _mymanager = new Manager();
            float mybalance = _mymanager.BalanceCheck();
            Assert.AreEqual(1200, mybalance);
        }
    }
}