using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InvestmentTracker
{
    public class InvestmentdbContext : DbContext
    {
        public DbSet<Income> Incomes { get; set; }

        public DbSet<Expenditure> Expenditures { get; set; }

        public DbSet<People> Peoples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) //OnConfiguring method defines connection option.
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InvestmentTracker;");
    }
}
