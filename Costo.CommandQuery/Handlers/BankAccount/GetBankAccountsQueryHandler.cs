using Cost.Contracts.Dto;
using Costo.Infrastructure.Query;
using Costo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Costo.CommandQuery.Queries;

namespace Costo.CommandQuery.Handlers
{
    public class GetBankAccountsQueryHandler : IQueryHandler<GetBankAccountsQuery, IEnumerable<BankAccountDto>>
    {
        private readonly IBankAccountRepository bankAccountRepository;

        public GetBankAccountsQueryHandler(IBankAccountRepository bankAccountRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
        }

        public async Task<IEnumerable<BankAccountDto>> Handle(GetBankAccountsQuery request, CancellationToken cancellationToken)
        {
            var bankAccounts = await bankAccountRepository.GetBankAccounts();
            return bankAccounts.Select(x => new BankAccountDto()
            {
                Name = x.Name,
                Balance = x.Balance,
                BankAccountType = x.AccountType,
                Description = x.Description,
                Icon = x.Icon
            });
        }
    }
}
