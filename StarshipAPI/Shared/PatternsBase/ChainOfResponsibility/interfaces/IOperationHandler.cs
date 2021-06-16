using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.ChainOfResponsibility.interfaces
{
    interface IOperationHandler
    {
        IOperationResult Operate(IOperation operation);
        void RegisterNextSector(IOperationHandler next);
    }
}
