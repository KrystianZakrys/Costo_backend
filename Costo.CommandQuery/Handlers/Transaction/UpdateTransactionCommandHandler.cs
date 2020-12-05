using System;
using Costo.CommandQuery.Commands;
using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.CommandQuery.Handlers
{
    public class UpdateTransactionCommandHandler : ICommandHandler<UpdateTransactionCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateTransactionCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await unitOfWork.TransactionRepository.GetTransaction(request.Id);

                entity.Update(request.Value, request.TransactionType, request.PaymentDate);

                var result = await unitOfWork.TransactionRepository.Update(entity);
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
