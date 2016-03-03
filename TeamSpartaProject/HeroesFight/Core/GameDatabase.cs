namespace HeroesFight.Core
{
    using HeroesFight.Interfaces;

    public class GameDatabase : IDataBase
    {
        public IHero Player { get; set; }

        public string PlayerName { get; set; }
    }
}