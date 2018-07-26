using System;

namespace AngryErrors
{
    public class ShrugException : Exception
    {
        private const string Shrug = "¯\\_(ツ)_/¯";

        public ShrugException()
            : base(Shrug)
        {
        }

        public ShrugException(string message)
            : base(Shrug + Environment.NewLine + message)
        {
        }

        public ShrugException(string message, Exception innerException)
            : base(Shrug + Environment.NewLine + message, innerException)
        {
        }
    }
}
