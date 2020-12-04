using Costo.CommandQuery.Commands;
using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Handlers
{
    public class DeleteTransactionCategoryCommandHandler : ICommandHandler<DeleteTransactionCategoryCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteTransactionCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteTransactionCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await unitOfWork.TransactionCategoryRepository.Delete(request.Id);
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
