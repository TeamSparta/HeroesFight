namespace HeroesFight.States
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public class ExitGameState : State
    {
        private Button btn_ExitGame;
        private Label lbl_EndGameResult;

        public ExitGameState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.LoadEndGameInfo();
        }

        public ICommandDispatcher CommandDispatcher { get; private set; }

        private void LoadEndGameInfo()
        {
            if (this.CommandDispatcher.Database.Player.HealthPoints > 0)
            {
                this.lbl_EndGameResult.Text = "You are victorious!";
            }
            else
            {
                this.lbl_EndGameResult.Text = "This time the odds might not been in your favor! Go back try your best!";
            }
        }

        private void InitializeComponent()
        {
            this.btn_ExitGame = new System.Windows.Forms.Button();
            this.lbl_EndGameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ExitGame
            // 
            this.btn_ExitGame.Location = new System.Drawing.Point(340, 284);
            this.btn_ExitGame.Name = "btn_ExitGame";
            this.btn_ExitGame.Size = new System.Drawing.Size(96, 23);
            this.btn_ExitGame.TabIndex = 0;
            this.btn_ExitGame.Text = "Exit game";
            this.btn_ExitGame.UseVisualStyleBackColor = true;
            this.btn_ExitGame.Click += new System.EventHandler(this.OnExitGameClick);
            // 
            // lbl_EndGameResult
            // 
            this.lbl_EndGameResult.AutoSize = true;
            this.lbl_EndGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_EndGameResult.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_EndGameResult.Location = new System.Drawing.Point(306, 220);
            this.lbl_EndGameResult.Name = "lbl_EndGameResult";
            this.lbl_EndGameResult.Size = new System.Drawing.Size(46, 17);
            this.lbl_EndGameResult.TabIndex = 1;
            this.lbl_EndGameResult.Text = "label1";
            // 
            // ExitGameState
            // 
            this.BackgroundImage = global::HeroesFight.Properties.Resources.EndGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.lbl_EndGameResult);
            this.Controls.Add(this.btn_ExitGame);
            this.Name = "ExitGameState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OnExitGameClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
