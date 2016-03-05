namespace HeroesFight.Entities.Commands
{
    using System;

    using HeroesFight.Enum;
    using HeroesFight.GameObjects.Heroes;

    using Interfaces;
    using States;

    public class CreatePlayerCommand : ICommand
    {
        public CreatePlayerCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

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

            IHero player = database.HeroFactory.CreateHero(heroType, database.PlayerName);
            database.AddPlayer(player as IPlayer);
            StateManager.ChangeCurrentState(StateEnum.FirstLevelRoundOneState);
        }
    }
}
