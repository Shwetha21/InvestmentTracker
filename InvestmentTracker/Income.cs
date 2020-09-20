using System;


namespace InvestmentTracker
{
    public partial class Income
    {
        public int IncomeId { get; set; }

        public DateTime Day { get; set; } 

        public int PeopleId { get; set; }

        public float IncomeReceived { get; set; }

        public string SourceOfIncome { get; set; }

        public People People { get; set; }


    }

}
