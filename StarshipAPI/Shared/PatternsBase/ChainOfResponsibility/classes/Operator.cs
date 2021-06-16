using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.interfaces
{
    public abstract class Operator
    {
        IOperation _operationLimit;
    }
}
