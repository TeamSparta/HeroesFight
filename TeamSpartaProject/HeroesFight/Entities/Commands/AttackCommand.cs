namespace HeroesFight.Entities.Commands
{
    #region

    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    #endregion

    public class AttackCommand : ICommand
    {
        public AttackCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            var state = currentState as FirstLevelRoundOneState;

            if (state == null)
            {
                throw new InvalidStateException();
            }

            int playerManaBeforeAttack = database.Player.ManaPoints;
            var currentEnemy = database.GetCurrentLevelEnemy();
            int enemyHealthBeforeAttack = currentEnemy.HealthPoints;

            string magicName = this.CommandParameters[0].ToString();
            switch (magicName)
            {
                case "firstMagic":
                    database.Player.PerformMagic(currentEnemy, database.GetCurrentMagicById(0));
                    break;
                case "secondMagic":
                    database.Player.PerformMagic(currentEnemy, database.GetCurrentMagicById(1));
                    break;
                case "thirdMagic":
                    database.Player.PerformMagic(currentEnemy, database.GetCurrentMagicById(2));
                    break;
                case "fourthMagic":
                    database.Player.PerformMagic(currentEnemy, database.GetCurrentMagicById(3));
                    break;
            }

            int enemyHealthAfterAttack = currentEnemy.HealthPoints;
            int playerManaAfterAttack = database.Player.ManaPoints;

            state.playerAttackInfoLabel.Text =
                $"You attacked {currentEnemy.Name} for {enemyHealthBeforeAttack - enemyHealthAfterAttack} damage "
                + $"({playerManaBeforeAttack - playerManaAfterAttack} mana)!";
            state.playerAttackInfoLabel.Visible = true;
        }
    }
}