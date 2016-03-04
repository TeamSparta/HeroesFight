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
            /*
            this.CommandDispatcher(InitializeLevelOneCommand);
            */
        }

        private void FirstLevelForm_Load(object sender, EventArgs e)
        {
        }
    }
}