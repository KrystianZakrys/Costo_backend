using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Costo.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        /// <summary>
        /// Gets or sets value;
        /// </summary>
        [Column(TypeName = "money")]
        public Decimal Value { get; protected set; }

        /// <summary>
        /// Gets or sets transaction type
        /// </summary>
        public TransactionType TransactionType { get; protected set; }


        /// <summary>
        /// Gets or sets payment date.
        /// </summary>
        public DateTime PaymentDate { get; protected set; }

        /// <summary>
        /// Gets or sets bank account
        /// </summary>
        public virtual BankAccount BankAccount { get; protected set; }

        /// <summary>
        /// Gets or sets transaction category
        /// </summary>
        public virtual TransactionCategory TransactionCategory { get; protected set; }

    }
}
