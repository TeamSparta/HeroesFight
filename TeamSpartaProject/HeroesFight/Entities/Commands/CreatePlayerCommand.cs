namespace HeroesFight.Entities.Commands
{
    using System;

    using HeroesFight.GameObjects.Heroes;

    using Interfaces;
    using States;

    public class CreatePlayerCommand : ICommand
    {
        public CreatePlayerCommand(string commandName, object[] commandParameters, IHeroFactory heroFactory)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
            this.HeroFactory = heroFactory;
        }

        public IHeroFactory HeroFactory { get; private set; }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            Type heroType;
            switch (this.CommandParameters[0].ToString())
            {
                case "Archer":
                    heroType = typeof(Archer);
                    break;
                case "Warrior":
                    heroType = typeof(Warrior);
                    break;
                default:
                    throw new ArgumentException("Unknown hero type.");
            }

            IHero player = this.HeroFactory.CreateHero(heroType, database.PlayerName);
            database.AddPlayer(player);
        }
    }
}
