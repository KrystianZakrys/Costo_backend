using Costo.Common.Enums;
using Costo.Common.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Costo.Domain.Entities
{
    public class BankAccount : SoftDeleteEntity
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public String Description { get; protected set; }

        /// <summary>
        /// Gets or sets balance.
        /// </summary>
        [Column(TypeName = "money")]
        public Decimal Balance { get; protected set; } = 0;
        
        /// <summary>
        /// Gets or sets account type.
        /// </summary>
        [NotMapped]
        public BankAccountType AccountType { get; protected set; }

        [Column("AccountType")]
        public String AccountTypeString
        {
            get { return AccountType.ToString(); }
            set { AccountType = value.ParseEnum<BankAccountType>(); }
        }

        /// <summary>
        /// Gets or sets icon
        /// </summary>
        [NotMapped]
        public Icon Icon { get; protected set; }

        [Column("Icon")]
        public string IconString
        {
            get { return Icon.ToString(); }
            protected set { Icon = value.ParseEnum<Icon>(); }
        }


        /// <summary>
        /// Gets or sets transactions.
        /// </summary>
        public ICollection<Transaction> Transactions { get; protected set; }

        /// <summary>
        /// Creates bank account entity
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="balance"></param>
        /// <param name="accountType"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public BankAccount Create(String name, String description, Decimal balance, BankAccountType accountType, Icon icon)
        {
            return new BankAccount()
            {
                Name = name,
                Description = description,
                Balance = balance,
                AccountType = accountType,
                Icon = Icon
            };
        }

        /// <summary>
        /// Update bank account.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="balance">balance</param>
        /// <param name="accountType">account type</param>
        /// <param name="icon">icon</param>
        public void Update(String name, String description, Decimal balance, BankAccountType accountType, Icon icon)
        {
            Name = name;
            Description = description;
            Balance = balance;
            AccountType = accountType;
            Icon = Icon;
        }

        /// <summary>
        /// Soft deletes entity.
        /// </summary>
        public void Delete()
        {
            IsDeleted = true;
        }
        
        public void SetBalance(Decimal balance)
        {
            Balance = balance;
        }

        /// <summary>
        /// Calculates actual bank account balance based on account transactions
        /// </summary>
        public decimal CalculateBalance()
        {
            decimal balance = Balance;
            foreach (var transaction in Transactions)
            {
               if(transaction.TransactionType == TransactionType.Income)
               {
                   balance += transaction.Value;
               }
               else
               {
                   balance -= transaction.Value;
               }
            }
            Balance = balance;
            return balance;
        }
    }
}
