using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Shared.Commands
{
    /// <summary>
    /// interface Agroup commandResults
    /// </summary>
    public interface ICommandResult
    {
        bool Sucess { get; set; }

        string Message { get; set; }

        object Data { get; set; }
    }
}
