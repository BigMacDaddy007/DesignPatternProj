using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.ChainOfResponsibility.interfaces
{
    public interface IOperationHandler
    {
        IOperationResult Operate(IOperation operation);
        void RegisterNextSector(IOperationHandler next);
    }
}
