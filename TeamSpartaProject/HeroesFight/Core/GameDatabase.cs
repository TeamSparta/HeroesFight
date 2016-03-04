namespace HeroesFight.Core
{
    using HeroesFight.Interfaces;

    public class GameDatabase : IDatabase
    {
        public IHero Player { get; private set; }

        public string PlayerName { get; private set; }

        public void AddPlayer(IHero player)
        {
            this.Player = player;
        }

        public void AddPlayerName(string playerName)
        {
            this.PlayerName = playerName;
        }
    }
}