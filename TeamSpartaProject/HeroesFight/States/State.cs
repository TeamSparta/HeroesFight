namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion

    public class State : Form
    {
        protected State()
        {
            this.InitializeComponent();
        }

        public virtual void Update()
        {
        }

        public virtual void Draw()
        {
        }

        public virtual void Initialize()
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // State
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "State";
            this.Load += new System.EventHandler(this.State_Load);
            this.ResumeLayout(false);

        }

        private void State_Load(object sender, EventArgs e)
        {
        }
    }
}