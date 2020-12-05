using Costo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cost.Contracts.Dto
{
    public class BankAccountDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Balance { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public Icon Icon { get; set; }

    }
}
