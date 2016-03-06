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
            string characterType = this.radioBtn_Warrior.Checked ? "Warrior" : "Archer";
            this.InitializeCharacter(characterType);
        }

        public ICommandDispatcher CommandDispatcher { get; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeCharacter(string characterType)
        {
            ////switch (characterType)
            ////{
            ////    case "Warrior":
            ////        GameDatabase.Player = new Warrior();
            ////        break;
            ////    case "Archer":
            ////        GameDatabase.Player = new Archer();
            ////        break;
            ////    default:
            ////        throw new ArgumentException("There is no such character.");
            ////}
        }

        private void OnArcherPictureBoxClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("CreatePlayer", new object[] { "Archer" });
        }

        private void OnWarriorPictureBoxClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("CreatePlayer", new object[] { "Warrior" });
        }

        private void SelectCharacterForm_Load(object sender, EventArgs e)
        {
        }
    }
}