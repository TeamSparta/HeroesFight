namespace HeroesFight.States
{
    using System;

    using HeroesFight.Interfaces;

    public partial class FirstLevelRoundOneState : State
    {
        public FirstLevelRoundOneState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDistpatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDistpatcher { get; private set; }

        private void OnBattleButtonClick(object sender, EventArgs e)
        {
            this.Btn_Attack.Visible = false;

            // ToDo: Check image transparency.
            this.CommandDistpatcher.ProcessCommand("InitializeLevelOne", null);
        }

        private void FirstLevelForm_Load(object sender, EventArgs e)
        {
           playerPictureBox.Visible = false;
           enemyPictureBox.Visible = false;
           firstSpellPictureBox.Visible = false;
           secondSpellPictureox.Visible = false;
        }

        private void OnFistMagicClick(object sender, EventArgs e)
        {
            this.CommandDistpatcher.ProcessCommand("Attack", new object[] { "firstSpell" });
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDistpatcher.ProcessCommand("Attack", new object[] { "secondSpell" });
        }
    }
}