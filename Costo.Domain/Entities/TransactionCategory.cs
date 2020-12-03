using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
        public Icon Icon { get; protected set; }

        /// <summary>
        /// Gets or sets sub categories
        /// </summary>
        public ICollection<TransactionCategory> SubCategories { get; protected set; }
    }
}
