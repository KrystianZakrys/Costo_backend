using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cost.Contracts.Dto
{
    public class TransactionCategoryDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Icon Icon { get; set; }
        public UIColor Color { get; set; }
        public ICollection<Guid> SubCategories { get; set; }
    }
}
