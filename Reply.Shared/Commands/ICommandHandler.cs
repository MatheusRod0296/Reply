using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Shared.Commands
{
    /// <summary>
    /// interface Agroup Handlers
    /// and difine de method Handler
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandHandler<T> where T : ICommand
    {        
        ICommandResult Handler(T command);
    }
}
