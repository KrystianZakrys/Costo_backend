using MediatR;
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
using System.Threading;

namespace Costo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IMediator mediator;

        public BankAccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets all bank account
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankAccountDto>>> Get()
        => Ok(await mediator.Send(new GetBankAccountsQuery(), CancellationToken.None));

        /// <summary>
        /// Adds new bank account
        /// </summary>
        /// <param name="BankAccountDto">data <seealso cref="BankAccountDto"/></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<BankAccountDto>> Post(BankAccountDto BankAccountDto)
            => Ok(await mediator.Send(new AddBankAccountCommand(BankAccountDto), CancellationToken.None));

        /// <summary>
        /// Updates existing bank account
        /// </summary>
        /// <param name="BankAccountDto">data <seealso cref="BankAccountDto"/></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<BankAccountDto>> Put(Guid id, BankAccountDto BankAccountDto)
            => Ok(await mediator.Send(new UpdateBankAccountCommand(id, BankAccountDto), CancellationToken.None));

        /// <summary>
        /// Deletes bank account
        /// </summary>
        /// <param name="id">bank account identifier</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<BankAccountDto>> Delete(Guid id)
            => Ok(await mediator.Send(new DeleteBankAccountCommand(id), CancellationToken.None));
    }
}
