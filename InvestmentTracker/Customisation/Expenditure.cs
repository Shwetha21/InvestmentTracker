using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentTracker
{
    public partial class Expenditure
    {
        public override string ToString()
        {
            return $" {ExpenditureId} -- {Day} -- £{ExpenseAmount} -- {PurposeOfExpenditure}";
        }
    }
}
