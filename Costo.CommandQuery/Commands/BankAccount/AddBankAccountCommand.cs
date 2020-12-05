using Cost.Contracts.Dto;
using Costo.Common.Enums;
using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class AddBankAccountCommand : CommandBase<bool>
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Balance { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public Icon Icon { get; set; }

        public AddBankAccountCommand(BankAccountDto bankAccountDto)
        {
            Name = bankAccountDto.Name;
            Description = bankAccountDto.Description;
            Balance = bankAccountDto.Balance;
            BankAccountType = bankAccountDto.BankAccountType;
            Icon = bankAccountDto.Icon;
        }
    }
}
