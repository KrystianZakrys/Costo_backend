using System;
using System.Collections.Generic;
using System.Text;

namespace Cost.Contracts.Dto
{
    public class SavingsGoalDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal GoalValue { get; set; }
        public decimal Value { get; set; }

    }
}
