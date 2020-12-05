using Costo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Costo.Infrastructure.Repositories
{
    public interface ITransactionRepository
    {
        // <summary>
        /// Gets transaction category list
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Transaction>> GetTransactions();
        Task<Transaction> GetTransaction(Guid id);
        Task<bool> Add(Transaction Transaction);
        Task<bool> Update(Transaction Transaction);
        Task<bool> Delete(Guid id);
    }

    public class TransactionRepository : ITransactionRepository
    {
        private readonly CostoContext dbContext;

        public TransactionRepository(CostoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await dbContext.Transactions.ToListAsync();
        }
        public async Task<Transaction> GetTransaction(Guid id)
        {
            return await dbContext.Transactions.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> Add(Transaction Transaction)
        {
            await dbContext.Transactions.AddRangeAsync(Transaction);
            return true;
        }
        public async Task<bool> Update(Transaction Transaction)
        {
            dbContext.Transactions.Update(Transaction);
            return true;
        }
        public async Task<bool> Delete(Guid id)
        {
            var entity = await dbContext.Transactions.SingleOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                dbContext.Transactions.Remove(entity);
                return true;
            }
            return false;
        }
    }
}
