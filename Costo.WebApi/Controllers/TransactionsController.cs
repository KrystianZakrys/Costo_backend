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
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator mediator;

        public TransactionsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets all transaction categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDto>>> Get()
        => Ok(await mediator.Send(new GetTransactionsQuery(), CancellationToken.None));

        /// <summary>
        /// Adds new transaction 
        /// </summary>
        /// <param name="transactionDto">data <seealso cref="TransactionDto"/></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TransactionDto>> Post(TransactionDto transactionDto)
            => Ok(await mediator.Send(new AddTransactionCommand(transactionDto), CancellationToken.None));

        /// <summary>
        /// Updates existing transaction 
        /// </summary>
        /// <param name="transactionDto">data <seealso cref="TransactionDto"/></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<TransactionDto>> Put(Guid id, TransactionDto transactionDto)
            => Ok(await mediator.Send(new UpdateTransactionCommand(id, transactionDto), CancellationToken.None));

        /// <summary>
        /// Deletes transaction 
        /// </summary>
        /// <param name="id">transaction  identifier</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransactionDto>> Delete(Guid id)
            => Ok(await mediator.Send(new DeleteTransactionCommand(id), CancellationToken.None));
    }
}
