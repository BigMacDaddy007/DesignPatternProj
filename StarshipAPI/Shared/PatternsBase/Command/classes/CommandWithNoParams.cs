using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.PatternsBase.Command.classes
{
    public abstract class CommandWithNoParams : ICommand
    {
        public ICommandResult Result { get { return null; } }
        public abstract void Execute();

        public abstract void Undo();

        public abstract void Validate();

    }
}
