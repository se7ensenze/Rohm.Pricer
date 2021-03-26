using System;
using System.Runtime.Serialization;

namespace Rohm.Pricer
{
    [Serializable]
    internal class NoContentException : Exception
    {
        public NoContentException()
        {
        }

        public NoContentException(string message) : base(message)
        {
        }

        public NoContentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoContentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}