using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.PatternsBase.ChainOfResponsibility.interfaces
{
    public interface IOperation
    {
        int Duration { get; set; }
        int Cost { get; set; }
    }
}
