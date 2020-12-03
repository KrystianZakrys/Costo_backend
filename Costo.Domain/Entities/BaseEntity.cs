using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Costo.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; protected set; } = Guid.NewGuid();
        /// <summary>
        /// Create date for audit data;
        /// </summary>
        public virtual DateTime CreateDate { get; protected set; } = DateTime.Now;
        /// <summary>
        /// Update date for audit data;
        /// </summary>
        public virtual DateTime UpdateDate { get; protected set; }
    }
}
