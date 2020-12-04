using System;
using System.Collections.Generic;
using System.Text;
using Cost.Contracts.Dto;
using Costo.Common.Enums;
using Costo.Infrastructure.Command;

namespace Costo.CommandQuery.Commands
{
    public class AddTransactionCategoryCommand : CommandBase<bool>
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Icon Icon { get; set; }
        public AddTransactionCategoryCommand(TransactionCategoryDto transactionCategoryDto)
        {
            Name = transactionCategoryDto.Name;
            Description = transactionCategoryDto.Description;
            Icon = transactionCategoryDto.Icon;
        }
    }
}
