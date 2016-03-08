namespace HeroesFight.States
{
    #region

    using System;

    using HeroesFight.Interfaces;

    #endregion

    public partial class FirstLevelRoundOneState : State
    {
        public FirstLevelRoundOneState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        private void FirstLevelForm_Load(object sender, EventArgs e)
        {
            this.playerPictureBox.Visible = false;
            this.enemyPictureBox.Visible = false;
            this.firstSpellPictureBox.Visible = false;
            this.secondSpellPictureox.Visible = false;
            this.CommandDispatcher.Database.Initialize();
        }

        private void OnBattleButtonClick(object sender, EventArgs e)
        {
            this.Btn_Attack.Visible = false;

            this.CommandDispatcher.ProcessCommand("InitializeLevelOne", null);
        }

        private void OnFirstMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "firstMagic" });

            this.CommandDispatcher.ProcessCommand("Update", null);
            this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
            this.CommandDispatcher.ProcessCommand("Update", null);
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });

            // Imagine if you try to click on magic and you have no mana/health to perform it. It will be counted as a turn and the enemy will attack you. 
            // And basically you will have not be done anything(action) so I believe is not appropriate that way.
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }
    }
}