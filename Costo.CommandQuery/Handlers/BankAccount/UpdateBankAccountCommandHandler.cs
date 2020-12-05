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
    public class UpdateBankAccountCommandHandler : ICommandHandler<UpdateBankAccountCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateBankAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateBankAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await unitOfWork.BankAccountRepository.GetBankAccount(request.Id);

                entity.Update(request.Name, request.Description, request.Balance, request.BankAccountType, request.Icon);

                var result = await unitOfWork.BankAccountRepository.Update(entity);
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
