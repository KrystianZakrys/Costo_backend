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
    public class GetTransactionCategoriesQueryHandler : IQueryHandler<GetTransactionCategoriesQuery, IEnumerable<TransactionCategoryDto>>
    {
        private readonly ITransactionCategoryRepository transactionCategoryRepository;

        public GetTransactionCategoriesQueryHandler(ITransactionCategoryRepository transactionCategoryRepository)
        {
            this.transactionCategoryRepository = transactionCategoryRepository;
        }

        public async Task<IEnumerable<TransactionCategoryDto>> Handle(GetTransactionCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await transactionCategoryRepository.GetCategories();

            return categories.Select(x => new TransactionCategoryDto() {
               Name = x.Name,
               Description = x.Description,
               Icon = x.Icon,
               SubCategories = x.SubCategories?.Select(y => y.Id).ToList(),
               Color = x.Color
            });
        }
    }
}
