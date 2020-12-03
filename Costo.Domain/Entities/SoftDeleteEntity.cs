using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Domain.Entities
{
    public class SoftDeleteEntity : BaseEntity
    {
        public bool IsDeleted { get; protected set; }
    }
}
