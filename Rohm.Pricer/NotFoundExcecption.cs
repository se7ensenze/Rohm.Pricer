using System;
using System.Runtime.Serialization;

namespace Rohm.Pricer
{
    [Serializable]
    internal class NotFoundExcecption : Exception
    {
        public NotFoundExcecption()
        {
        }

        public NotFoundExcecption(string message) : base(message)
        {
        }

        public NotFoundExcecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundExcecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}