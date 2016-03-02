namespace HeroesFight.Core
{
    using HeroesFight.Interfaces;

    public class GameDatabase : IDataBase
    {
        public string PlayerName { get; set; }

        public IHero Player { get; set; }
    }
}