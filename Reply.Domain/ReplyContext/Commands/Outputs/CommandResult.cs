using Reply.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Commands.Outputs
{
    /// <summary>
    /// structure for Output Data
    /// </summary>
    public struct CommandResult : ICommandResult
    {
        public CommandResult(bool sucess, string message, object data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public bool Sucess { get; set ; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
