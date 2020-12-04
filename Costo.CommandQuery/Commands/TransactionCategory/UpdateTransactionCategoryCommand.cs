using Cost.Contracts.Dto;
using Costo.Common.Enums;
using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class UpdateTransactionCategoryCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Icon Icon { get; set; }

        public UpdateTransactionCategoryCommand(Guid id, TransactionCategoryDto transactionCategoryDto)
        {
            Name = transactionCategoryDto.Name;
            Description = transactionCategoryDto.Description;
            Icon = transactionCategoryDto.Icon;
            Id = id;
        }
    }
}
