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
        public virtual DateTime CreateDate { get; protected set; } = DateTime.Now;
    }
}
