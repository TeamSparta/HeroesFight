namespace HeroesFight.States
{
    #region

    using System;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    #endregion

    public partial class SelectCharacterState : State
    {
        public SelectCharacterState(ICommandDispatcher commandDispatcher)
        {
            this.InitializeComponent();
            this.CommandDispatcher = commandDispatcher;
        }

        public ICommandDispatcher CommandDispatcher { get; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnArcherPictureBoxClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("CreatePlayer", new object[] { "Archer" });
        }

        private void OnWarriorPictureBoxClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("CreatePlayer", new object[] { "Warrior" });
        }

        private void SelectCharacterState_Load(object sender, EventArgs e)
        {
        }
    }
}