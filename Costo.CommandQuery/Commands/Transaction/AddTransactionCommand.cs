using System;
using System.Collections.Generic;
using System.Text;
using Cost.Contracts.Dto;
using Costo.Common.Enums;
using Costo.Infrastructure.Command;

namespace Costo.CommandQuery.Commands
{
    public class AddTransactionCommand : CommandBase<bool>
    {
        public decimal Value { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid BankAccount { get; set; }
        public Guid TransactionCategory { get; set; }

        public AddTransactionCommand(TransactionDto transactionDto)
        {
            Value = transactionDto.Value;
            TransactionType = transactionDto.TransactionType;
            PaymentDate = transactionDto.PaymentDate;
            BankAccount = transactionDto.BankAccount;
            TransactionCategory = transactionDto.TransactionCategory;
        }
    }
}
