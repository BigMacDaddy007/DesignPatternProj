using Shared.PatternsBase.ChainOfResponsibility.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.ChainOfResponsibility.classes
{
    public abstract class Operator
    {
        IOperation _operationLimit;
    }
}
