using System;
using Costo.CommandQuery.Commands;
using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Handlers
{
    public class UpdateTransactionCategoryCommandHandler : ICommandHandler<UpdateTransactionCategoryCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateTransactionCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateTransactionCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await unitOfWork.TransactionCategoryRepository.GetCategory(request.Id);

                entity.Update(request.Name,request.Description, request.Icon);

                var result = await unitOfWork.TransactionCategoryRepository.Update(entity);
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
