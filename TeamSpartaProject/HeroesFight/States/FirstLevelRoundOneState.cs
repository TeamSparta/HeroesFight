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
            this.CommandDistpatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDistpatcher { get; }

        private void FirstLevelForm_Load(object sender, EventArgs e)
        {
            this.playerPictureBox.Visible = false;
            this.enemyPictureBox.Visible = false;
            this.firstSpellPictureBox.Visible = false;
            this.secondSpellPictureox.Visible = false;
        }

        private void OnBattleButtonClick(object sender, EventArgs e)
        {
            this.Btn_Attack.Visible = false;

            this.CommandDistpatcher.ProcessCommand("InitializeLevelOne", null);
        }

        private void OnFistMagicClick(object sender, EventArgs e)
        {
            this.CommandDistpatcher.ProcessCommand("Attack", new object[] { "firstMagic" });
            this.CommandDistpatcher.ProcessCommand("Update", null);
            this.CommandDistpatcher.ProcessCommand("EnemyAttack", null);
            this.CommandDistpatcher.ProcessCommand("Update", null);
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDistpatcher.ProcessCommand("Attack", new object[] { "secondMagic" });
            this.CommandDistpatcher.ProcessCommand("Update", null);
            this.CommandDistpatcher.ProcessCommand("EnemyAttack", null);
            this.CommandDistpatcher.ProcessCommand("Update", null);

        }
    }
}