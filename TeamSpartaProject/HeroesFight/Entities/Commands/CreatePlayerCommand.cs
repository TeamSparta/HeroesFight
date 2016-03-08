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
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            ClassHeroEnum heroType;
            switch (commandInfo.CommandParameters[0].ToString())
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