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

        [Test]
        public void WhenIncomeAmountEnteredIsNotValidExceptionThrown()
        {
            Manager _mymanager = new Manager();
            var ex = Assert.Throws<System.Exception>(() => _mymanager.AddIncome(-1, ""));
            Assert.AreEqual($"Invalid input or source of income is empty", ex.Message, "Exception message not correct");
        }

        [Test]
        public void WhenExpenditureAmountEnteredIsNotValidExceptionThrown()
        {
            Manager _mymanager = new Manager();
            var ex = Assert.Throws<System.Exception>(() => _mymanager.AddExpenditure(0, ""));
            Assert.AreEqual($"Invalid input or pupose of expenditure is empty", ex.Message, "Exception message not correct");
        }
    }
}