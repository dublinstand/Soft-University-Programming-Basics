using System;
using System.Runtime.Serialization;

namespace УчебнаЗала
{
    [Serializable]
    internal class ArgumentOutOfBoundsException : Exception
    {
        public ArgumentOutOfBoundsException()
        {
        }

        public ArgumentOutOfBoundsException(string message) : base(message)
        {
        }

        public ArgumentOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}