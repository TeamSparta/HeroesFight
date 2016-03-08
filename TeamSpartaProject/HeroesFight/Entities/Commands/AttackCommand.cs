namespace HeroesFight.Entities.Commands
{
    #region

    using System;

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

                // TODO: don't understand why here is used FirstLevelRoundOneState
            if (state == null)
            {
                throw new InvalidStateException();
            }

            string magicName = this.CommandParameters[0].ToString();
            IMagic magic;
            switch (magicName)
            {
                case "firstMagic":
                    magic = database.GetCurrentMagicById(0);
                    break;
                case "secondMagic":
                    magic = database.GetCurrentMagicById(1);
                    break;
                case "thirdMagic":
                    magic = database.GetCurrentMagicById(2);
                    break;
                case "fourthMagic":
                    magic = database.GetCurrentMagicById(3);
                    break;
                default:
                    throw new ArgumentException("Magic not supported!");
            }

            int playerManaBeforeAttack = database.Player.ManaPoints;
            var currentEnemy = database.GetCurrentLevelEnemy();
            int enemyHealthBeforeAttack = currentEnemy.HealthPoints;

            if (playerManaBeforeAttack < magic.ManaCost)
            {
                state.playerAttackInfoLabel.Text =
                    $"Not enough mana. {Math.Abs(playerManaBeforeAttack - magic.ManaCost)} needed.";
            }
            else if (database.Player.HealthPoints < magic.HealthCost)
            {
                state.playerAttackInfoLabel.Text =
                    $"Not enough health. {Math.Abs(playerManaBeforeAttack - magic.ManaCost)} needed.";
            }
            else
            {
                database.Player.PerformMagic(currentEnemy, magic);

                int enemyHealthAfterAttack = currentEnemy.HealthPoints;
                int playerManaAfterAttack = database.Player.ManaPoints;

                state.playerAttackInfoLabel.Text =
                    $"You attacked {currentEnemy.Name} for {enemyHealthBeforeAttack - enemyHealthAfterAttack} damage "
                    + $"({playerManaBeforeAttack - playerManaAfterAttack} mana)!";
                state.playerAttackInfoLabel.Visible = true;
            }
        }
    }
}