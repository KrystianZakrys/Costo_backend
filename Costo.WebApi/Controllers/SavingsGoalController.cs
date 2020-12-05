using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cost.Contracts.Dto;
using Costo.CommandQuery.Queries;
using Costo.CommandQuery.Handlers;
using Costo.CommandQuery.Commands;
using MediatR;
using System.Threading;

namespace Costo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsGoalController : ControllerBase
    {
        private readonly IMediator mediator;

        public SavingsGoalController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets all transaction categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsGoalDto>>> Get()
        => Ok(await mediator.Send(new GetSavingsGoalsQuery(), CancellationToken.None));

        /// <summary>
        /// Adds new transaction category
        /// </summary>
        /// <param name="SavingsGoalDto">data <seealso cref="SavingsGoalDto"/></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<SavingsGoalDto>> Post(SavingsGoalDto SavingsGoalDto)
            => Ok(await mediator.Send(new AddSavingsGoalCommand(SavingsGoalDto), CancellationToken.None));

        /// <summary>
        /// Updates existing transaction category
        /// </summary>
        /// <param name="SavingsGoalDto">data <seealso cref="SavingsGoalDto"/></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<SavingsGoalDto>> Put(Guid id, SavingsGoalDto SavingsGoalDto)
            => Ok(await mediator.Send(new UpdateSavingsGoalCommand(id, SavingsGoalDto), CancellationToken.None));

        /// <summary>
        /// Deletes transaction category
        /// </summary>
        /// <param name="id">transaction category identifier</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<SavingsGoalDto>> Delete(Guid id)
            => Ok(await mediator.Send(new DeleteSavingsGoalCommand(id), CancellationToken.None));
    }
}
