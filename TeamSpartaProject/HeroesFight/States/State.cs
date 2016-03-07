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
            // this.Load += this.State_Load; TODO: to remove
            this.ResumeLayout(false);
        }

        // TODO: to remov
        //private void State_Load(object sender, EventArgs e)
        //{
        //}
    }
}