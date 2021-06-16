using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.Command.classes
{
    public abstract class CommandExecuteParams
    {
        string _commandName;

        public string CommandName { get { return this._commandName; } }

        public CommandExecuteParams(string commandName)
        {
            this._commandName = commandName;
        }
    }
}
