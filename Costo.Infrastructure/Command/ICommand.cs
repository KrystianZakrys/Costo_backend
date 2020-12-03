using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Infrastructure.Command
{  
   /// <summary>
   /// Interface for command
   /// </summary>
    public interface ICommand : IRequest
    {
    }

    /// <summary>
    /// Interface for command with result
    /// </summary>
    /// <typeparam name="TResult">The type of result</typeparam>
    public interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
}
