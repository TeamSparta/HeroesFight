namespace HeroesFight.States
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public class State : Form
    {
        public State(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        protected ICommandDispatcher CommandDispatcher { get; }

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
