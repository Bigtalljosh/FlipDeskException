using System;

namespace AngryErrors
{
    public class SadException : Exception
    {
        private const string Sad = "ε(´סּ︵סּ`)з" + AngryErrorsHelpers.SomethingWrong;

        public SadException()
            : base(Sad)
        {
        }

        public SadException(string message)
            : base(Sad + Environment.NewLine + message)
        {
        }

        public SadException(string message, Exception innerException)
            : base(Sad + Environment.NewLine + message, innerException)
        {
        }
    }
}