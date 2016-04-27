using System;

namespace Flip.Desk
{
    public class FlipException : Exception
    {
        private string message = "(╯°□°）╯︵ ┻━┻   Something went wrong.... : \r\n";

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
    }
}
