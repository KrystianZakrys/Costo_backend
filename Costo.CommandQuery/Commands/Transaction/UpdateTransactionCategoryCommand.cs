using Cost.Contracts.Dto;
using Costo.Common.Enums;
using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class UpdateTransactionCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public decimal Value { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid BankAccount { get; set; }
        public Guid TransactionCategory { get; set; }

        public UpdateTransactionCommand(Guid id, TransactionDto transactionDto)
        {            
            Id = id;
            Value = transactionDto.Value;
            TransactionType = transactionDto.TransactionType;
            PaymentDate = transactionDto.PaymentDate;
            BankAccount = transactionDto.BankAccount;
            TransactionCategory = transactionDto.TransactionCategory;
        }
    }
}
