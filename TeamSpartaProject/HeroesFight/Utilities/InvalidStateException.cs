namespace HeroesFight.Utilities
{
    #region

    using System;

    #endregion

    public class InvalidStateException : ArgumentException
    {
        public InvalidStateException()
            : base(Constants.InvalidStateExceptionMessage)
        {
        }
    }
}