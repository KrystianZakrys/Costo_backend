using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Domain.Entities
{
    public class Income : BaseEntity
    {
        /// <summary>
        /// Gets or sets value;
        /// </summary>
        public Decimal Value { get; protected set; }
    }
}
