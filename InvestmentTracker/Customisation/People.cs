using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentTracker
{
    public partial class People
    {
        public override string ToString()
        {
            return $" {PeopleId} -- {Name}";
        }
    }
}
