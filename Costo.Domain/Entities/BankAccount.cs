using Costo.Infrastructure.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Domain.Entities
{
    public class BankAccount : BaseEntity
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
        public Decimal Balance { get; protected set; }
        
        /// <summary>
        /// Gets or sets account type.
        /// </summary>
        public BankAccountType AccountType { get; protected set; }

        /// <summary>
        /// Gets or sets icon.
        /// </summary>
        public Icon Icon { get; protected set; }

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
        
    }
}
