using Cost.Contracts.Dto;
using Costo.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.CommandQuery.Commands
{
    public class UpdateSavingsGoalCommand : CommandBase<bool>
    {
        public new Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal GoalValue { get; set; }
        public decimal Value { get; set; }

        public UpdateSavingsGoalCommand(Guid id, SavingsGoalDto savingsGoalDto)
        {
            Id = id;
            Name = savingsGoalDto.Name;
            Description = savingsGoalDto.Description;
            GoalValue = savingsGoalDto.GoalValue;
            Value = savingsGoalDto.Value;
        }
    }
}
