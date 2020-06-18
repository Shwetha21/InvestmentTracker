using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentTracker
{
    public partial class Expenditure
    {
        public int ExpenditureId { get; set; }
        public DateTime Day { get; set; }

        public float ExpenseAmount { get; set; }

        public string PurposeOfExpenditure { get; set; }

    }
}
