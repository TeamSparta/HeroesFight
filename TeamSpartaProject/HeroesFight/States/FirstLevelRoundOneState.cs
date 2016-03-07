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

        public ICommandDispatcher CommandDispatcher { get; private set; }

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
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }
    }
}