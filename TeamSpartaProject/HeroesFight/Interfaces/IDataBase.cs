namespace HeroesFight.Interfaces
{
    public interface IDataBase
    {
        string PlayerName { get; set; }

        IHero Player { get; }
    }
}
