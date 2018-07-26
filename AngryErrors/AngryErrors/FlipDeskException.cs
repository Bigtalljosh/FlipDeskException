using System;

namespace AngryErrors
{
    public class FlipDeskException : Exception
    {
        private const string FlipDesk = "(╯°□°）╯︵ ┻━┻ " + AngryErrorsHelpers.SomethingWrong;

        public FlipDeskException()
            : base(FlipDesk)
        {
        }

        public FlipDeskException(string message)
            : base(FlipDesk + Environment.NewLine + message)
        {
        }

        public FlipDeskException(string message, Exception innerException)
            : base(FlipDesk + Environment.NewLine + message, innerException)
        {
        }
    }
}
