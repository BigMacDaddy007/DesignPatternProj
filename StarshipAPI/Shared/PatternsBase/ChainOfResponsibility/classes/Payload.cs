using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Shared.PatternsBase.ChainOfResponsibility.classes
{
    public class Payload : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
