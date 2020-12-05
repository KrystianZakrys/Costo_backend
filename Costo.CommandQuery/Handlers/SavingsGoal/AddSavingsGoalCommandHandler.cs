using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Commands
{
    public class AddSavingsGoalCommandHandler : ICommandHandler<AddSavingsGoalCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public AddSavingsGoalCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddSavingsGoalCommand request, CancellationToken cancellationToken)
        {
            var savingsGoal = SavingsGoal.Create(request.Name, request.Description, request.GoalValue,request.Value);
            try
            {
                var result = await unitOfWork.SavingsGoalRepository.Add(savingsGoal);
                unitOfWork.Commit();
                return result;
            }
            catch (Exception e)
            {
                unitOfWork.Rollback();
                return false;
            }
        }
    }
}
