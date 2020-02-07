using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Shared.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {        
        ICommandResult Handler(T command);
    }
}
