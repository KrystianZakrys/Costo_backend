using Cost.Contracts.Dto;
using Costo.Infrastructure.Query;
using System;
using System.Collections.Generic;

namespace Costo.CommandQuery.Queries
{
    public class GetTransactionsQuery : IQuery<IEnumerable<TransactionDto>>
    {
    }
}
