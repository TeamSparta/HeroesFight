namespace HeroesFight.Utilities
{
    #region

    using System;

    #endregion

    public class MagicNotFoundException : Exception
    {
        public MagicNotFoundException(string message)
            : base(message)
        {
        }
    }
}