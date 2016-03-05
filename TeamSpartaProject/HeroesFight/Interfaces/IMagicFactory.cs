namespace HeroesFight.Interfaces
{
    public interface IMagicFactory
    {
        IMagic GetMagic(string magicName, IDatabase database);
    }
}
