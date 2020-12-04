using Cost.Contracts.Dto;
using Costo.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Queries
{
    /// <summary>
    /// Query for employee implementing <seealso cref="IQuery{TResult}"/>
    /// </summary>
    public class GetTransactionCategoriesQuery : IQuery<IEnumerable<TransactionCategoryDto>>
    {

    }
}
