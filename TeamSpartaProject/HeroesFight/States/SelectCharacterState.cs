namespace HeroesFight.States
{
    using System;
    using System.Windows.Forms;

    public partial class SelectCharacterState : State
    {
        private static SelectCharacterState instance;

        public SelectCharacterState()
        {
            this.InitializeComponent();

            string characterType = this.radioBtn_Warrior.Checked ? "Warrior" : "Archer";
            this.InitializeCharacter(characterType);
        }

        public static SelectCharacterState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SelectCharacterState();
                }

                return instance;
            }
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
    }
}