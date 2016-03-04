namespace HeroesFight.Interfaces
{
    public interface IDatabase
    {
        string PlayerName { get; }

        IHero Player { get; }

        void AddPlayer(IHero player);

        void AddPlayerName(string playerName);
    }
}
