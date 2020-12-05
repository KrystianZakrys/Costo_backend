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
    public class DeleteBankAccountCommandHandler : ICommandHandler<DeleteBankAccountCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteBankAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteBankAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await unitOfWork.BankAccountRepository.Delete(request.Id);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                unitOfWork.Rollback();
                return false;
            }
        }
    }
}
