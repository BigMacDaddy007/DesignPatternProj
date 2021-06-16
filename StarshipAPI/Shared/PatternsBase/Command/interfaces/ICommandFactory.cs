using Command.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.Command.interfaces
{
    public interface ICommandFactory
    {
        String CommandName { get; }
        String CommandDescription { get; }]

        ICommand MakeCommand(CommandExecuteParams arguments);

    }
}
