using Costo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Costo.Infrastructure.Repositories
{
    public interface ITransactionCategoryRepository
    {
        // <summary>
        /// Gets transaction category list
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TransactionCategory>> GetCategories();
        Task<TransactionCategory> GetCategory(Guid id);
        Task<bool> Add(TransactionCategory transactionCategory);
        Task<bool> Update(TransactionCategory transactionCategory);
        Task<bool> Delete(Guid id);
    }

    public class TransactionCategoryRepository : ITransactionCategoryRepository
    {
        private readonly CostoContext dbContext;

        public TransactionCategoryRepository(CostoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<TransactionCategory>> GetCategories()
        {
            return await dbContext.TransactionCategories.ToListAsync();
        }
        public async Task<TransactionCategory> GetCategory(Guid id)
        {
            return await dbContext.TransactionCategories.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> Add(TransactionCategory transactionCategory)
        {
            dbContext.TransactionCategories.Add(transactionCategory);
            return true;
        }
        public async Task<bool> Update(TransactionCategory transactionCategory)
        {
            dbContext.TransactionCategories.Update(transactionCategory);
            return true;
        }
        public async Task<bool> Delete(Guid id)
        {
            var entity = await dbContext.TransactionCategories.SingleOrDefaultAsync(x => x.Id == id);
            if(entity != null)
            {
                dbContext.TransactionCategories.Remove(entity);
                return true;
            }            
            return false;
        }
    }
}
