using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Costo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsGoalController : ControllerBase
    {
        private readonly IMediator mediator;

        public TransactionsCategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets all transaction categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionCategoryDto>>> Get()
        => Ok(await mediator.Send(new GetTransactionCategoriesQuery(), CancellationToken.None));

        /// <summary>
        /// Adds new transaction category
        /// </summary>
        /// <param name="transactionCategoryDto">data <seealso cref="TransactionCategoryDto"/></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TransactionCategoryDto>> Post(TransactionCategoryDto transactionCategoryDto)
            => Ok(await mediator.Send(new AddTransactionCategoryCommand(transactionCategoryDto), CancellationToken.None));

        /// <summary>
        /// Updates existing transaction category
        /// </summary>
        /// <param name="transactionCategoryDto">data <seealso cref="TransactionCategoryDto"/></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<TransactionCategoryDto>> Put(Guid id, TransactionCategoryDto transactionCategoryDto)
            => Ok(await mediator.Send(new UpdateTransactionCategoryCommand(id, transactionCategoryDto), CancellationToken.None));

        /// <summary>
        /// Deletes transaction category
        /// </summary>
        /// <param name="id">transaction category identifier</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransactionCategoryDto>> Delete(Guid id)
            => Ok(await mediator.Send(new DeleteTransactionCategoryCommand(id), CancellationToken.None));
    }
}
