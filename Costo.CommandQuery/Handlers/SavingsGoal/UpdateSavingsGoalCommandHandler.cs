using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Commands
{
    public class UpdateSavingsGoalCommandHandler : ICommandHandler<UpdateSavingsGoalCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateSavingsGoalCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateSavingsGoalCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await unitOfWork.SavingsGoalRepository.GetSavingsGoal(request.Id);

                entity.Update(request.Name,request.Description,request.GoalValue, request.Value);
                var result = await unitOfWork.SavingsGoalRepository.Update(entity);

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
