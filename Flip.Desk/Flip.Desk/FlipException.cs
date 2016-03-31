using System;
using System.Runtime.Serialization;

namespace Flip.Desk
{
    [Serializable]
    public class FlipException : Exception
    {
        private string message = "(╯°□°）╯︵ ┻━┻   Something went wrong.... :";

        public FlipException()
        {
        }

        public FlipException(string message) : base(message)
        {
            this.message += base.Message;
        }

        public FlipException(string message, Exception innerException) : base(message, innerException)
        {
            this.message += base.Message;
        }

        protected FlipException(SerializationInfo info, StreamingContext context): base(info, context)
        {
            this.message += base.Message;
        }
    }
}
