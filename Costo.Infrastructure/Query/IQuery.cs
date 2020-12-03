using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure.Query
{
    /// <summary>
    /// Interface for query
    /// </summary>
    /// <typeparam name="TResult">The tyoe if the result.</typeparam>
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
