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
            this.warriorTooltip.SetToolTip(
                this.warriorPictureBox,
                "Warrior is typical combat unit. Has a strong attack power and high armour.");
            this.warriorTooltip.ShowAlways = true;
            this.warriorTooltip.ReshowDelay = 500;

            this.archerTooltip.SetToolTip(this.archerPictureBox, "Archer is swift and fast. Huge attack power which comes at it price.");
            this.archerTooltip.ShowAlways = true;
            this.archerTooltip.ReshowDelay = 500;
        }
    }
}