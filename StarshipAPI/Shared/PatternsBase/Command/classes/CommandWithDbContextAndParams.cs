using Shared.PatternsBase.Command.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.PatternsBase.Command.classes;

namespace StarshipAPI.Shared.PatternsBase.Command.classes
{
    public abstract class CommandWithDbContextAndParams : ICommand
    {
        private CommandExecuteParams _params;
        public CommandExecuteParams Params { get { return this._params; } }

        private DbContext _context;
        public DbContext Context { get { return this._context; } }

        CommandWithDbContextAndParams(CommandExecuteParams parameters, DbContext context)
        {
            this._context = context;
            this._params = parameters;
        }

        public abstract void Execute();

        public abstract void Validate();

        public abstract void Undo();
    }
}
