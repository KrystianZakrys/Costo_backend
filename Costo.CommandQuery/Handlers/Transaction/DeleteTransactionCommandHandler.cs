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
    public class DeleteTransactionCommandHandler : ICommandHandler<DeleteTransactionCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteTransactionCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await unitOfWork.TransactionRepository.Delete(request.Id);
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
