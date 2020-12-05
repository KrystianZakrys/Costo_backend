using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class DeleteSavingsGoalCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }

        public DeleteSavingsGoalCommand(Guid id)
        {
            Id = id;
        }
    }
}
