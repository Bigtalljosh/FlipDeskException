using System;

namespace AngryErrors
{
    public class HappyException : Exception
    {
        private const string Happy = "ε(´^_^')з" + AngryErrorsHelpers.SomethingWrong;

        public HappyException()
            : base(Happy)
        {
        }

        public HappyException(string message)
            : base(Happy + Environment.NewLine + message)
        {
        }

        public HappyException(string message, Exception innerException)
            : base(Happy + Environment.NewLine + message, innerException)
        {
        }
    }
}