namespace HeroesFight.Utilities
{
    using System;

    public class MagicNotFoundException : Exception
    {
        public MagicNotFoundException(string message)
            : base(message)
        {
        }
    }
}
