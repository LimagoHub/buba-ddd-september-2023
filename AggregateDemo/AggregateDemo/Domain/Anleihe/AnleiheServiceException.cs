using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDemo.domain.Anleihe
{
    public class AnleiheServiceException: Exception
    {
        public AnleiheServiceException()
        {
        }

        protected AnleiheServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public AnleiheServiceException(string? message) : base(message)
        {
        }

        public AnleiheServiceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
