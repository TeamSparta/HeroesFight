namespace HeroesFight.Entities.Commands
{
    using System;

    using HeroesFight.Enum;

    using Interfaces;
    using States;

    public class CreatePlayerCommand : ICommand
    {
        public CreatePlayerCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; private set; }

        public object[] CommandParameters { get; private set; }

        public void Execute(IDatabase database, State currentState)
        {
            ClassHeroEnum heroType;
            switch (this.CommandParameters[0].ToString())
            {
                case "Archer":
                    heroType = ClassHeroEnum.Archer;
                    break;
                case "Warrior":
                    heroType = ClassHeroEnum.Warrior;
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
