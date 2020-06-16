using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentTracker
{
    public partial class Income
    {
        public override string ToString()
        {
            return $" {IncomeId} {IncomeReceived} {Day}";
        }
    }
}
