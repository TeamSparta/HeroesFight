namespace HeroesFight.Utilities
{
    using System;

    public class InvalidStateException : ArgumentException
    {
        public InvalidStateException() 
            : base(Constants.InvalidStateExceptionMessage)
        {
        }
    }
}
