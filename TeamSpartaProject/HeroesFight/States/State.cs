namespace HeroesFight.States
{
    using System.Windows.Forms;

    public class State : Form
    {
        public State()
        {
            this.InitializeComponent();
        }

#region
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
#endregion
        private void State_Load(object sender, System.EventArgs e)
        {
        }
    }
}
