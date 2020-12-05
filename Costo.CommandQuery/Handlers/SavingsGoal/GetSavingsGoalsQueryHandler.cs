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
    public class GetSavingsGoalsQueryHandler : IQueryHandler<GetSavingsGoalsQuery, IEnumerable<SavingsGoalDto>>
    {
        private readonly ISavingsGoalRepository savingsGoalRepository;

        public GetSavingsGoalsQueryHandler(ISavingsGoalRepository savingsGoalRepository)
        {
            this.savingsGoalRepository = savingsGoalRepository;
        }

        public async Task<IEnumerable<SavingsGoalDto>> Handle(GetSavingsGoalsQuery request, CancellationToken cancellationToken)
        {
            var savingGoals = await savingsGoalRepository.GetSavingsGoals();
            return savingGoals.Select(x => new SavingsGoalDto() { 
                Description = x.Description,
                GoalValue = x.GoalValue,
                Name = x.Name,
                Value = x.Value
            });
        }
    }
}
