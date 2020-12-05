using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Costo.CommandQuery.Commands;
using Costo.Common.Enums;
using Costo.Domain.Entities;
using Costo.Infrastructure.Command;
using Costo.Infrastructure.Repositories;

namespace Costo.CommandQuery.Handlers
{
    public class AddTransactionCommandHandler : ICommandHandler<AddTransactionCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public AddTransactionCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddTransactionCommand request, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                var bankAccount = await unitOfWork.BankAccountRepository.GetBankAccount(request.BankAccount);
                var transactionCategory = await unitOfWork.TransactionCategoryRepository.GetCategory(request.TransactionCategory);
                if(bankAccount != null && transactionCategory != null)
                {
                    var transaction = Transaction.Create(request.Value, request.TransactionType, request.PaymentDate, bankAccount,transactionCategory);
                    result = await unitOfWork.TransactionRepository.Add(transaction);
                    unitOfWork.Commit();
                }
              
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
