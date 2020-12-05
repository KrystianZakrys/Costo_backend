using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        ITransactionCategoryRepository TransactionCategoryRepository { get; }
        IBankAccountRepository BankAccountRepository { get; }
        ISavingsGoalRepository SavingsGoalRepository { get; }
        ITransactionRepository TransactionRepository { get; }

        void Commit();
        void Rollback();
    }
}
