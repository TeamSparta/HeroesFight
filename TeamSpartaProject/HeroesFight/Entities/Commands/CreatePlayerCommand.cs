namespace HeroesFight.Entities.Commands
{
    #region

    using System;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

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
            database.Update();
            StateManager.ChangeCurrentState(StateEnum.FirstLevelRoundOneState);
        }
    }
}