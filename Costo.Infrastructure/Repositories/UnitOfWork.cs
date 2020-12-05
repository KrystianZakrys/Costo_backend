using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CostoContext costoContext;
        private ITransactionCategoryRepository transactionCategoryRepository;
        private IBankAccountRepository bankAccountRepository;
        private ISavingsGoalRepository savingsGoalRepository;
        private ITransactionRepository transactionRepository;

        public UnitOfWork(CostoContext costoContext)
        {
            this.costoContext = costoContext;
        }

        public ITransactionCategoryRepository TransactionCategoryRepository
        {
            get { return transactionCategoryRepository ?? new TransactionCategoryRepository(costoContext); }
        }

        public IBankAccountRepository BankAccountRepository
        {
            get { return BankAccountRepository ?? new BankAccountRepository(costoContext); }
        }
        public ISavingsGoalRepository SavingsGoalRepository
        {
            get { return savingsGoalRepository ?? new SavingsGoalRepository(costoContext); }
        }
        public ITransactionRepository TransactionRepository
        {
            get { return transactionRepository ?? new TransactionRepository(costoContext); }
        }

        public void Commit()
        {
            costoContext.SaveChanges();
        }

        public void Rollback()
        {
            costoContext.Dispose();
        }
    }
}
