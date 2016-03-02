namespace HeroesFight
{
    using System;
    using System.Windows.Forms;

    public partial class SelectCharacterForm : Form
    {
        private static SelectCharacterForm instance;

        public SelectCharacterForm()
        {
            this.InitializeComponent();

            string characterType = this.radioBtn_Warrior.Checked ? "Warrior" : "Archer";
            this.InitializeCharacter(characterType);
        }

        public static SelectCharacterForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SelectCharacterForm();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}