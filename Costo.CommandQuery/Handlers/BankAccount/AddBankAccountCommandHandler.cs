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
    public class AddBankAccountCommandHandler : ICommandHandler<AddBankAccountCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public AddBankAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddBankAccountCommand request, CancellationToken cancellationToken)
        {
            var bankAccount = BankAccount.Create(request.Name,request.Description, request.Balance, request.BankAccountType, request.Icon);
            try
            {
                var result = await unitOfWork.BankAccountRepository.Add(bankAccount);
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
