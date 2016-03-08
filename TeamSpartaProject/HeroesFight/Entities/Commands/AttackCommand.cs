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
        public void Execute(IDatabase database, State currentState, CommandInfo commandInfo)
        {
            string magicName = commandInfo.CommandParameters[0].ToString();
            IMagic magic;
            switch (magicName)
            {
                case "firstMagic":
                    magic = database.GetPlayerMagicById(0);
                    break;
                case "secondMagic":
                    magic = database.GetPlayerMagicById(1);
                    break;
                case "thirdMagic":
                    magic = database.GetPlayerMagicById(2);
                    break;
                case "fourthMagic":
                    magic = database.GetPlayerMagicById(3);
                    break;
                default:
                    throw new ArgumentException("Magic not supported!");
            }

            int playerManaBeforeAttack = database.Player.ManaPoints;
            var currentEnemy = database.GetCurrentLevelEnemy();
            int enemyHealthBeforeAttack = currentEnemy.HealthPoints;

            /*
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
                int enemyHealthAfterAttack = currentEnemy.HealthPoints;
                int playerManaAfterAttack = database.Player.ManaPoints;
                state.playerAttackInfoLabel.Text =
                    $"You attacked {currentEnemy.Name} for {enemyHealthBeforeAttack - enemyHealthAfterAttack} damage "
                    + $"({playerManaBeforeAttack - playerManaAfterAttack} mana)!";
                state.playerAttackInfoLabel.Visible = true;
            }
            */

            database.Player.PerformMagic(currentEnemy, magic);
        }
    }
}