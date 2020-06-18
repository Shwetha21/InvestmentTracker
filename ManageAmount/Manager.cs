using System;
using InvestmentTracker;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Reflection.Metadata;

namespace ManageAmount
{
    public class Manager
    {
        public Income SelectedIncome { get; set; }
        public Expenditure SelectedExpenditure { get; set; }

        public Manager()
        {

        }

        // Adding entry to database
        public void AddIncome(float amount, string source)
        {
            using(var db = new InvestmentdbContext())
            {
                db.Add(new Income { IncomeReceived = amount, Day = DateTime.Now ,SourceOfIncome = source });
                db.SaveChanges();
            }
        }

        public void AddExpenditure(float amount, string purpose)
        {
            using (var db = new InvestmentdbContext())
            {
                db.Add(new Expenditure { ExpenseAmount = amount, Day = DateTime.Now , PurposeOfExpenditure = purpose});
                db.SaveChanges();
            }
        }


         // Display The data
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


        public void SetSelectedIncome(object selectedItem)
        {
            SelectedIncome = (Income)selectedItem;
        }

        public void SetSelectedExpenditure(object selectedItem)
        {
            SelectedExpenditure = (Expenditure)selectedItem;
        }


        //To find the total income (Query the DataBase)
        public float TotalIncome()
        {
            float total = 0;
            using (var db = new InvestmentdbContext())
            {
                total = db.Incomes.Sum(s => s.IncomeReceived);
            }
            return total;
        }


         // To find Total expenditure
        public float TotalExpenditure()
        {
            float total = 0;
            using (var db = new InvestmentdbContext())
            {
                total = db.Expenditures.Sum(s => s.ExpenseAmount);
            }
            return total;
        }

        //to Delete Wrong Income
        public void Delete_Income(int id)
        {
            using (var db = new InvestmentdbContext())
            {
                var queryIncome = db.Incomes.OrderBy(i => i.IncomeId);

               // var fid = (float)id;
                foreach (var Iid in queryIncome)
                {
                    if(Iid.IncomeId == id)
                    {
                        db.Remove(Iid);
                    }
                }
                db.SaveChanges();
            }
        }

        //to Delete Wrong Expenditure
        public void Delete_Expenditure(int id)
        {
            using (var db = new InvestmentdbContext())
            {
                var queryIncome = db.Expenditures.OrderBy(i => i.ExpenditureId);

                foreach (var Eid in queryIncome)
                {
                    if (Eid.ExpenditureId == id)
                    {
                        db.Remove(Eid);
                    }
                }
                db.SaveChanges();
            }
        }

        //To check the balance
        public float BalanceCheck()
        {
            float TIncome = TotalIncome();
            float TExpenditure = TotalExpenditure();
            if (TIncome - TExpenditure >= 0)
            {
                return TIncome - TExpenditure;
            }
            else
            {
                return 0; //if 0 display you are in debt.
            }
        }

        //To update the wrong entry made in Income Table

        public void Update_Income (int id , float income, string source)
        {
            using (var db = new InvestmentdbContext())
            {
                var SIncome = db.Incomes.OrderBy(i => i.IncomeId);
                foreach (var Iid in SIncome)
                {
                    if (Iid.IncomeId == id)
                    {
                        Iid.IncomeReceived = income;
                        Iid.SourceOfIncome = source;
                    }
                }
                db.SaveChanges();
            }

        }

        //To update the wrong entry made in Expenditure Table
        public void Update_Expenditure(int id, float expenditure, string purpose)
        {
            using (var db = new InvestmentdbContext())
            {
                var SExpenditure = db.Expenditures.OrderBy(e => e.ExpenditureId);
                foreach(var Eid in SExpenditure)
                {
                    if(Eid.ExpenditureId == id)
                    {
                        Eid.ExpenseAmount = expenditure;
                        Eid.PurposeOfExpenditure = purpose;
                    }
                }
                db.SaveChanges();
            }
        }

    }
}
