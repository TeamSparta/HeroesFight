namespace HeroesFight
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class HeroesFightStartForm : Form
    {
        public HeroesFightStartForm()
        {
            this.InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnStartGameButtonClick(object sender, EventArgs e)
        {
            this.btnExitGame.Visible = false;
            this.btnStartGame.Visible = false;

            this.Btn_ConitueToPickClass.Visible = true;
            this.Lbl_EnterYourName.Visible = true;
            this.TxtBox_PlayerName.Visible = true;
        }

        private void HeroesFightStartForm_Load(object sender, EventArgs e)
        {

        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnPickNameLabelClick(object sender, EventArgs e)
        {
        }

        private void OnNameTextBoxChange(object sender, EventArgs e)
        {
        }

        private void OnContinueButtonClick(object sender, EventArgs e)
        {
            
            string playerName = this.TxtBox_PlayerName.Text;

            // This logic have to be isolated.
            Regex nameRegex = new Regex(@"([\w]+){3,20}");

            if (!nameRegex.IsMatch(playerName))
            {
                MessageBox.Show(
                    "Name should be between 3 and 20 characters long and should consist only letters and digits. Please try again!");
                this.TxtBox_PlayerName.Clear();
            }
            else
            {
                // ToDo: Log playerName information.
                this.Hide();
                SelectCharacterForm.Instance.Show();
            }
        }
    }
}