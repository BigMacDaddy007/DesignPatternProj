using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.Command.interfaces
{
    public interface ICommand
    {
        public ICommandResult Result { get; }

        // All Commands Interact with DB if Persistence is Required.
        public void Execute();
        public void Validate();

        public void Undo();
    }
}
