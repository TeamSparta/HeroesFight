namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion

    public class State : Form
    {
        public State()
        {
            this.InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // State
            this.ClientSize = new Size(284, 262);
            this.Name = "State";
            this.ResumeLayout(false);
        }
    }
}