using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class DeleteTransactionCategoryCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public DeleteTransactionCategoryCommand(Guid id)
        {
            Id = id;
        }
    }
}
