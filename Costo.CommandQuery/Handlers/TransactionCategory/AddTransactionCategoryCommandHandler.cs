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
    public class AddTransactionCategoryCommandHandler : ICommandHandler<AddTransactionCategoryCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public AddTransactionCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddTransactionCategoryCommand request, CancellationToken cancellationToken)
        {
            var transactionCategory = TransactionCategory.Create(request.Name, request.Description, request.Icon, request.Color);
            try
            {
                var result = await unitOfWork.TransactionCategoryRepository.Add(transactionCategory);
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
