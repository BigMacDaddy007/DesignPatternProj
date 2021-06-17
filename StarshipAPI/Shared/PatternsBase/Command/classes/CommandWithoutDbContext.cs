using Shared.PatternsBase.Command.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;

namespace StarshipAPI.Shared.PatternsBase.Command.classes
{
    public abstract class CommandWithoutDbContext : ICommand
    {
   
        public ICommandResult Result { get { return null; } }

        public CommandWithoutDbContext() {}

        public abstract void Execute();

        public abstract bool Validate();

        public abstract void Undo();
    }
}
