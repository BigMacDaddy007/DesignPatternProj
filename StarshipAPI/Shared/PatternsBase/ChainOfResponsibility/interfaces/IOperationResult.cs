using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Shared.constants;
using Shared.PatternsBase.ChainOfResponsibility.classes;

namespace Shared.PatternsBase.ChainOfResponsibility.interfaces
{
    public interface IOperationResult
    {
        ResultStatus Status { get; set; } 
        DateTime CompletedDate { get; set; } 
        Payload getPayload();
    }
}
