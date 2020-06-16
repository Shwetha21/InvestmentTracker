using System;
using InvestmentTracker;
using System.Linq;
using System.Collections.Generic;

namespace ManageAmount
{
    public class Manager
    {
        public Manager()
        {

        }

        public void AddIncome(int amount, DateTime day)
        {
            using(var db = new InvestmentdbContext())
            {
                db.Add(new Income { IncomeReceived = amount, Day = day });
                db.SaveChanges();
            }
        }

        public void AddExpenditure(int amount, DateTime day)
        {
            using (var db = new InvestmentdbContext())
            {
                db.Add(new Expenditure { ExpenseAmount = amount, Day = day });
                db.SaveChanges();
            }
        }

        public List<Income> DisplayIncome()
        {
            using (var db = new InvestmentdbContext())
            {
                return db.Incomes.ToList();
            }
        }

        public List<Expenditure> DisplayExpenditure()
        {
            using (var db = new InvestmentdbContext())
            {
                return db.Expenditures.ToList();
            }
        }


    }
}
