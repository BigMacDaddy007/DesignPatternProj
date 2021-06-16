using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.Command.interfaces
{
    public interface ICommand
    {
        public void Execute();
        public void Validate();
    }
}
