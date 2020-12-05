using Costo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Costo.Infrastructure.Repositories
{
        public interface IBankAccountRepository
        {
            // <summary>
            /// Gets transaction category list
            /// </summary>
            /// <returns></returns>
            Task<IEnumerable<BankAccount>> GetBankAccounts();
            Task<BankAccount> GetBankAccount(Guid id);
            Task<bool> Add(BankAccount BankAccount);
            Task<bool> Update(BankAccount BankAccount);
            Task<bool> Delete(Guid id);
        }

        public class BankAccountRepository : IBankAccountRepository
        {
            private readonly CostoContext dbContext;

            public BankAccountRepository(CostoContext dbContext)
            {
                this.dbContext = dbContext;
            }

            public async Task<IEnumerable<BankAccount>> GetBankAccounts()
            {
                return await dbContext.BankAccounts.ToListAsync();
            }
            public async Task<BankAccount> GetBankAccount(Guid id)
            {
                return await dbContext.BankAccounts.FirstOrDefaultAsync(x => x.Id == id);
            }
            public async Task<bool> Add(BankAccount BankAccount)
            {
                await dbContext.BankAccounts.AddRangeAsync(BankAccount);
                return true;
            }
            public async Task<bool> Update(BankAccount BankAccount)
            {
                dbContext.BankAccounts.Update(BankAccount);
                return true;
            }
            public async Task<bool> Delete(Guid id)
            {
                var entity = await dbContext.BankAccounts.SingleOrDefaultAsync(x => x.Id == id);
                if (entity != null)
                {
                    dbContext.BankAccounts.Remove(entity);
                    return true;
                }
                return false;
            }
        }
    }
