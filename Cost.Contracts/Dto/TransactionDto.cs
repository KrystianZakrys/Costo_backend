using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cost.Contracts.Dto
{
    public class TransactionDto
    {
        public decimal Value { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid BankAccount { get; set; }
        public Guid TransactionCategory { get; set; }
    }
}
