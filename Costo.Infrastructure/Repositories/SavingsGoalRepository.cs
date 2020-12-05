using Costo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Costo.Infrastructure.Repositories
{
    public interface ISavingsGoalRepository
    {
        // <summary>
        /// Gets transaction category list
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SavingsGoal>> GetSavingsGoals();
        Task<SavingsGoal> GetSavingsGoal(Guid id);
        Task<bool> Add(SavingsGoal SavingsGoal);
        Task<bool> Update(SavingsGoal SavingsGoal);
        Task<bool> Delete(Guid id);
    }

    public class SavingsGoalRepository : ISavingsGoalRepository
    {
        private readonly CostoContext dbContext;

        public SavingsGoalRepository(CostoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SavingsGoal>> GetSavingsGoals()
        {
            return await dbContext.SavingsGoals.ToListAsync();
        }
        public async Task<SavingsGoal> GetSavingsGoal(Guid id)
        {
            return await dbContext.SavingsGoals.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> Add(SavingsGoal SavingsGoal)
        {
            await dbContext.SavingsGoals.AddRangeAsync(SavingsGoal);
            return true;
        }
        public async Task<bool> Update(SavingsGoal SavingsGoal)
        {
            dbContext.SavingsGoals.Update(SavingsGoal);
            return true;
        }
        public async Task<bool> Delete(Guid id)
        {
            var entity = await dbContext.SavingsGoals.SingleOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                dbContext.SavingsGoals.Remove(entity);
                return true;
            }
            return false;
        }
    }
}
