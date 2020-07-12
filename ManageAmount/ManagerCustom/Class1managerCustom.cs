using System;
using System.Collections.Generic;
using System.Text;
using InvestmentTracker;

namespace ManageAmount
{
    public class Class1managerCustom : Manager
    {

        private Income _incomemoney;
        private Expenditure _expendituremoney;
        public Class1managerCustom(Income _incomemoney, Expenditure _expendituremoney, People _people) : base(_incomemoney, _expendituremoney, _people)
        {

        }

        public Class1managerCustom()
        {
           
        }

        public override float TotalIncome()
        {
            float total = 0;
           // total = _incomemoney.Sum(s => s.IncomeReceived);
            return total;
        }
    }
}
