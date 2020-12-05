using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Commands
{
    public class DeleteSavingsGoalCommandHandler : ICommandHandler<DeleteSavingsGoalCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteSavingsGoalCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteSavingsGoalCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await unitOfWork.SavingsGoalRepository.Delete(request.Id);
                unitOfWork.Commit();
                return result;
            }
            catch (Exception e)
            {
                unitOfWork.Rollback();
                throw;
            }
        }
    }
}
