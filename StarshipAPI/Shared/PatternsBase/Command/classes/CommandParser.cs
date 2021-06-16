using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shared.PatternsBase.Command.classes
{
    public abstract class CommandParser
    {
        readonly IEnumerable<ICommandFactory> _commands;

        CommandParser(IEnumerable<ICommandFactory> commands)
        {
            this._commands = commands;
        }

        public ICommand ParseCommand(CommandExecuteParams command)
        {
            ICommandFactory requestedCommand = this.FindCommand(command.CommandName);

            return requestedCommand.MakeCommand(command);
        }

        public IEnumerable<ICommandFactory> GetAvailabelCommands()
        {
            return this._commands;
        }

        public void ExecuteCommand(CommandExecuteParams command)
        {
            ParseCommand(command).Execute();
        }

        public void AddCommand(ICommandFactory command)
        {
            this._commands.Append(command);
        }

        public ICommandFactory FindCommand(string command)
        {
            return this._commands.FirstOrDefault(cmd => cmd.CommandName == command);
        }
    }
}
