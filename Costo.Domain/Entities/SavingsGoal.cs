using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Costo.Domain.Entities
{
    public class SavingsGoal : SoftDeleteEntity
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
        /// Gets or sets goal value
        /// </summary>
        [Column(TypeName = "money")]
        public Decimal GoalValue { get; protected set; }

        /// <summary>
        /// Gets or sets actual value
        /// </summary>
        [Column(TypeName = "money")]
        public Decimal Value { get; protected set; } = 0;

        public static SavingsGoal Create(String name, String description, decimal goalValue, decimal value)
        {
            return new SavingsGoal()
            {
                Name = name,
                Description = description,
                GoalValue = goalValue,
                Value = value
            };
        }

        public void Update(String name, String description, decimal goalValue, decimal value)
        {
            Name = name;
            Description = description;
            GoalValue = goalValue;
            Value = value;            
        }
    }
}
