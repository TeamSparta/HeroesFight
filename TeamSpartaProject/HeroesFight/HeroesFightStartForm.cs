namespace HeroesFight
{
    using System;
    using System.Windows.Forms;

    public partial class HeroesFightStartForm : Form
    {
        public HeroesFightStartForm()
        {
            this.InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectCharacterForm.Instance.Show();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}