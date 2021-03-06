﻿using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class DeleteBankAccountCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public DeleteBankAccountCommand(Guid id)
        {
            Id = id;
        }
    }
}
