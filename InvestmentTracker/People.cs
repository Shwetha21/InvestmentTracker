using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentTracker
{
    public partial class People
    {
        public int PeopleId { get; set; }

        public string Name { get; set; }

       public ICollection<Income> Incomes { get; set; }
       public ICollection<Expenditure> Expenditures { get; set; }

        
    }
}
