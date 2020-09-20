using System;
using InvestmentTracker;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ManageAmount
{
    public class Manager
    {
        private readonly Income _incomemoney;

        private readonly Expenditure _expendituremoney;

        private readonly People _people;

        public Income SelectedIncome { get; set; }
        public Expenditure SelectedExpenditure { get; set; }
        public People SelectedPeople { get; set; }

        public string[] IncomeSource { get; set; }

        public string[] PurposeExpenditure { get; set; }

        public string[] Name { get; set; }
        

        public Manager()
        {

        }

        public Manager(Income incomemoney,Expenditure expendituremoney, People people)
        {
            _incomemoney = incomemoney;
            _expendituremoney = expendituremoney;
            _people = people;
        }

      

        // To give options to the user on categories to select.

        public List<string> DisplayPeopleName()
        {
            var listofnames = new List<string>();
            using (var db = new InvestmentdbContext())
            {
                var QueryPeople = db.Peoples;
                foreach( var p in QueryPeople)
                {
                   listofnames.Add(p.Name);
                }

                return listofnames;
               
            }
        }

       

        public string[] DisplaysourceIncome()
        {
            IncomeSource = new string[] { "Salary", "Gift","Cash Back","Others"};
            return IncomeSource;
        }

        public string[] DisplayPurposeExpenditure()
        {
            PurposeExpenditure = new string[] { "Groceries", "Car Loan", "Home Loan","Rent", "Bills","Other" };
            return PurposeExpenditure;
        }

        // Adding entry to database with exception handling
        public void AddIncome(float amount, string source, string name)
        {
            if (amount <= 0 )
            {
                throw new Exception("Invalid input");
            }
            else
            {
                using (var db = new InvestmentdbContext())
                {
                    var q1 = db.Peoples.Where(p => p.Name == name);

                    foreach( var p in q1)
                    {
                        db.Add(new Income { IncomeReceived = amount, Day = DateTime.Now, SourceOfIncome = source, PeopleId = p.PeopleId});
                    }
                    
                    db.SaveChanges();
                }
                
            }
        }

        public void AddExpenditure(float amount, string purpose, string name)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                using (var db = new InvestmentdbContext())
                {
                    var q2 = db.Peoples.Where(p => p.Name == name);
                    foreach (var p in q2)
                    {
                        db.Add(new Expenditure { ExpenseAmount = amount, Day = DateTime.Now, PurposeOfExpenditure = purpose, PeopleId = p.PeopleId });
                       
                    }
                    db.SaveChanges();
                }
                
            }
        }

        public void AddPersonName(string PersonName)
        {
            using (var db = new InvestmentdbContext())
            {
                db.Add(new People {Name = PersonName});
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

        public List<People> DisplayPeople()
        {
            using (var db = new InvestmentdbContext())
            {
                return db.Peoples.ToList();
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
        public void SetSelectedPeople(object selectedItem)
        {
            SelectedPeople = (People)selectedItem;
        }


        //To find the total income(Query the DataBase)
        public virtual float TotalIncome()
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

        public void Delete_People(int id)
        {
            using (var db = new InvestmentdbContext())
            {
                var peopleId = db.Peoples.OrderBy(i => i.PeopleId);

                foreach(var Pid in peopleId)
                {
                    if(Pid.PeopleId == id)
                    {
                        db.Remove(Pid);
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

        //To calculate Total income monthwise
        public object Monthly_Income()
        {
            using (var db = new InvestmentdbContext())
            {
                
                var monthlyIncome = db.Incomes
                  .Select(x => new
                  {
                      x.Day.Month,
                      x.IncomeReceived
                  })
                  .GroupBy(x => x.Month, x => x.IncomeReceived,
                   (Key, values) => new { Month = Key, MonthlyIncome = values.Sum() }).ToList(); 
                                    

                return monthlyIncome;
            }    
        }

        //To calculate total expenditure monthwise

        public object Monthy_Expenditure()
        {
            using (var db = new InvestmentdbContext())
            {
                var monthlyExpenditure = db.Expenditures
                    .Select(y => new
                    {
                        y.Day.Month,
                        y.ExpenseAmount
                    })
                    .GroupBy(y => y.Month, y => y.ExpenseAmount,
                    (Key, values) => new { Month = Key, MonthlyExpense = values.Sum() }).ToList();

                return monthlyExpenditure;
            }

        }
    }
}
