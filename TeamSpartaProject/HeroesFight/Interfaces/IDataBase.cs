namespace HeroesFight.Interfaces
{
    public interface IDatabase
    {
        string PlayerName { get; }

        IHero Player { get; }

        // TODO: Not sure if the 2 methods below are needed
        void AddPlayer(IHero player);

        void AddPlayerName(string playerName);
    }
}
