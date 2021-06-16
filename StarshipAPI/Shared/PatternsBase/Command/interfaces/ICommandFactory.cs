using Shared.PatternsBase.Command.classes;
using System;

namespace Shared.PatternsBase.Command.interfaces
{
    public interface ICommandFactory
    {
        String CommandName { get; }
        String CommandDescription { get; }
        ICommand MakeCommand();
    }
}
