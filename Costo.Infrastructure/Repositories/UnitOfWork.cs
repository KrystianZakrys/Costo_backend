using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CostoContext costoContext;
        private ITransactionCategoryRepository transactionCategoryRepository;

        public UnitOfWork(CostoContext costoContext)
        {
            this.costoContext = costoContext;
        }

        public ITransactionCategoryRepository TransactionCategoryRepository
        {
            get { return transactionCategoryRepository ?? new TransactionCategoryRepository(costoContext); }
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
