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

        [NotMapped]
        public UIColor Color { get; protected set; }

        [Column("Color")]
        public string ColorString
        {
            get { return Color.ToString(); }
            protected set { Color = value.ParseEnum<UIColor>(); }
        }

        /// <summary>
        /// Gets or sets sub categories
        /// </summary>
        [Column("ParentCategory")]
        public ICollection<TransactionCategory> SubCategories { get; protected set; }

        public static TransactionCategory Create(string name, string description, Icon icon, UIColor color)
        {
            return new TransactionCategory()
            {
                Name = name,
                Description = description,
                Icon = icon,
                Color = color
            };
        }

        public void Update(String name, String description, Icon icon, UIColor color)
        {
            Name = name;
            Description = description;
            Icon = icon;
            Color = color;
        }

        public void Update(TransactionCategory transactionCategory)
        {

            Name = transactionCategory.Name;
            Description = transactionCategory.Description;
            Icon = transactionCategory.Icon;
            Color = transactionCategory.Color;
            SubCategories = transactionCategory.SubCategories;                
        }
    }
}
