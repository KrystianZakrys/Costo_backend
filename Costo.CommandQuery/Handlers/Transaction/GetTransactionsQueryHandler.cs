using Cost.Contracts.Dto;
using Costo.Infrastructure.Query;
using Costo.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Costo.CommandQuery.Queries;

namespace Costo.CommandQuery.Handlers
{
    public class GetTransactionsQueryHandler : IQueryHandler<GetTransactionsQuery, IEnumerable<TransactionDto>>
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactionsQueryHandler(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public async Task<IEnumerable<TransactionDto>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
        {
            var transactions = await transactionRepository.GetTransactions();

            return transactions.Select(x => new TransactionDto() {
               BankAccount = x.BankAccount.Id,
               PaymentDate = x.PaymentDate,
               TransactionCategory = x.TransactionCategory.Id,
               TransactionType = x.TransactionType,
               Value = x.Value
            });;
        }
    }
}
