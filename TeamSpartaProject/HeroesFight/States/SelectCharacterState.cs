namespace HeroesFight.States
{
    using System;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public partial class SelectCharacterState : State
    {
        public SelectCharacterState(ICommandDispatcher commandDispatcher) 
            : base(commandDispatcher)
        {
            this.InitializeComponent();

            string characterType = this.radioBtn_Warrior.Checked ? "Warrior" : "Archer";
            this.InitializeCharacter(characterType);
        }

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

        private void SelectCharacterForm_Load(object sender, EventArgs e)
        {
        }

        private void OnWarriorPictureBoxClick(object sender, EventArgs e)
        {
            thi
        }

        private void OnArcherPictureBoxClick(object sender, EventArgs e)
        {
        }
    }
}