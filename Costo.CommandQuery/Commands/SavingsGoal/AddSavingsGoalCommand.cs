using Cost.Contracts.Dto;
using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class AddSavingsGoalCommand : CommandBase<bool>
    {
        public string Name { get; set; }
        public String Description { get; set; }
        public decimal GoalValue { get; set; }
        public decimal Value { get; set; }

        public AddSavingsGoalCommand(SavingsGoalDto savingsGoalDto)
        {
            Name = savingsGoalDto.Name;
            Description = savingsGoalDto.Description;
            GoalValue = savingsGoalDto.GoalValue;
            Value = savingsGoalDto.Value;
        }
    }
}
