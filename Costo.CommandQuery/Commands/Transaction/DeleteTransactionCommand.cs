using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class DeleteTransactionCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public DeleteTransactionCommand(Guid id)
        {
            Id = id;
        }
    }
}
