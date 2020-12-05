using Cost.Contracts.Dto;
using Costo.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Queries
{
    public class GetSavingsGoalsQuery : IQuery<IEnumerable<SavingsGoalDto>>
    {
    }
}
