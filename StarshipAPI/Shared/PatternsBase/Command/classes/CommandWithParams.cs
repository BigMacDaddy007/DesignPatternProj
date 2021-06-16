using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.PatternsBase.Command.classes
{
    public abstract class CommandWithParams : ICommand
    {
        private CommandExecuteParams _params;

        public CommandExecuteParams Params { get { return this._params; } }
        CommandWithParams(CommandExecuteParams parameters)
        {
            this._params = parameters;
        }

        public abstract void Execute();

        public abstract void Validate();

        public abstract void Undo();
    }
}
