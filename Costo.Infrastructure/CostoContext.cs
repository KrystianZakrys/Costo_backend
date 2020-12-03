using Costo.Common.Enums;
using Costo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure
{
    public class CostoContext :  DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionCategory> TransactionCategories { get; set; }

        public CostoContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory[]
           {
                TransactionCategory.Create("Wypłata","...",Icon.Money),
                TransactionCategory.Create("Przychód","...",Icon.Money),
                TransactionCategory.Create("Wydatek","...",Icon.Money),
                TransactionCategory.Create("Zakupy spożywcze","...",Icon.Money),
                TransactionCategory.Create("Transport","...",Icon.Money),
                TransactionCategory.Create("Zdrowie","...",Icon.Money),
                TransactionCategory.Create("Rozrywka","...",Icon.Money),
                TransactionCategory.Create("Dom","...",Icon.Money),
                TransactionCategory.Create("Restauracje","...",Icon.Money),
           });

        }
    }
}
