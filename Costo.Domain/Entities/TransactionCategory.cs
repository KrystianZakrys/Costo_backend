using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Costo.Common.Extensions;

namespace Costo.Domain.Entities
{
    public class TransactionCategory : BaseEntity
    {
        /// <summary>
        /// Gets or sets name
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        public String Description { get; protected set; }

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
        /// Gets or sets sub categories
        /// </summary>
        [Column("ParentCategory")]
        public ICollection<TransactionCategory> SubCategories { get; protected set; }

        public static TransactionCategory Create(string name, string description, Icon icon)
        {
            return new TransactionCategory()
            {
                Name = name,
                Description = description,
                Icon = icon
            };
        }

        public void Update(String name, String description, Icon icon)
        {
            Name = name;
            Description = description;
            Icon = icon;
        }

        public void Update(TransactionCategory transactionCategory)
        {

            Name = transactionCategory.Name;
            Description = transactionCategory.Description;
            Icon = transactionCategory.Icon;
            SubCategories = transactionCategory.SubCategories;
                
        }
    }
}
