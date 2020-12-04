using Cost.Contracts.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Costo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsCategoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public TransactionsCategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionCategoryDto>> Get()
        => Ok(await mediator.Send(new Query(), CancellationToken.None));
    }
}
