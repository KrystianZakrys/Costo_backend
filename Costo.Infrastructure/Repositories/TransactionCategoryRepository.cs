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
    }
}
