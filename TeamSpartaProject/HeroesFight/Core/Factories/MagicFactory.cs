namespace HeroesFight.Core.Factories
{
    using System;

    using HeroesFight.Interfaces;

    public class MagicFactory : IMagicFactory
    {
        public IMagic GetMagic(string magicName, IDatabase database)
        {
            throw new NotImplementedException();
        }
    }
}
