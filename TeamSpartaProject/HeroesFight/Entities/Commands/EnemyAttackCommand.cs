namespace HeroesFight.Entities.Commands
{
    #region

    using System;
    using System.Linq;

    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class EnemyAttackCommand : ICommand
    {
        public EnemyAttackCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            var currentEnemy = database.GetCurrentLevelEnemy();
            var state = currentState;
            Random randomSpell = new Random();
            var possibleMagics = currentEnemy.Magics.Where(m => m.ManaCost <= currentEnemy.ManaPoints).ToList();
            int randomSpellNumber = randomSpell.Next(0, possibleMagics.Count);

            IMagic resultMagic = possibleMagics[randomSpellNumber];

            int currentEnemyManaBeforeAttack = currentEnemy.ManaPoints;
            int playerHealthBeforeAttack = database.Player.HealthPoints;

            currentEnemy.PerformMagic(database.Player, resultMagic);

            int playerHealthAfterAttack = database.Player.HealthPoints;
            int enemyManaAfterAttack = currentEnemy.ManaPoints;

            // ToDo: Show msg.
            ////state.enemyAttackInfoLabel.Text =
            ////    $"You attacked {database.PlayerName} for {playerHealthBeforeAttack - playerHealthAfterAttack} damage "
            ////    + $"({currentEnemyManaBeforeAttack - enemyManaAfterAttack} mana)!";

            ////state.enemyAttackInfoLabel.Visible = true;
        }
    }
}