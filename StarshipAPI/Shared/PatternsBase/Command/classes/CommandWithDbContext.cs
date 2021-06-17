using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.PatternsBase.Command.classes
{
    public abstract class CommandWithDbContext : ICommand
    {
        private DbContext _context;

        public DbContext Context { get { return this._context; } }

        public ICommandResult Result { get; set; }

        public CommandWithDbContext(DbContext context)
        {
            this._context = context;
        }

        public abstract void Execute();

        public abstract void Undo();

        public abstract bool Validate();
    }
}
