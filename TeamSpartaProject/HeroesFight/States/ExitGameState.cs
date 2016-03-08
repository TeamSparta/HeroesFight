namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class ExitGameState : State
    {
        private Button btn_ExitGame;
        private Label victoriousLabel;
        private Label loserLabel;

        public ExitGameState(ICommandDispatcher commandDispatcher)
        {
            this.InitializeComponent();
            this.CommandDispatcher = commandDispatcher;
            this.LoadEndGameInfo();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        private void InitializeComponent()
        {
            this.btn_ExitGame = new System.Windows.Forms.Button();
            this.loserLabel = new System.Windows.Forms.Label();
            this.victoriousLabel = new System.Windows.Forms.Label();
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
            this.btn_ExitGame.Click += new System.EventHandler(this.OnExitGameButtonClick);
            // 
            // loserLabel
            // 
            this.loserLabel.AutoSize = true;
            this.loserLabel.BackColor = System.Drawing.Color.Transparent;
            this.loserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loserLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.loserLabel.Location = new System.Drawing.Point(119, 219);
            this.loserLabel.Name = "loserLabel";
            this.loserLabel.Size = new System.Drawing.Size(570, 20);
            this.loserLabel.TabIndex = 1;
            this.loserLabel.Text = "This time the odds might not been in your favor! Go back try your best!";
            this.loserLabel.Visible = false;
            // 
            // victoriousLabel
            // 
            this.victoriousLabel.AutoSize = true;
            this.victoriousLabel.BackColor = System.Drawing.Color.Transparent;
            this.victoriousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.victoriousLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.victoriousLabel.Location = new System.Drawing.Point(307, 250);
            this.victoriousLabel.Name = "victoriousLabel";
            this.victoriousLabel.Size = new System.Drawing.Size(158, 20);
            this.victoriousLabel.TabIndex = 2;
            this.victoriousLabel.Text = "You are victorious!";
            this.victoriousLabel.Visible = false;
            // 
            // ExitGameState
            // 
            this.BackgroundImage = global::HeroesFight.Properties.Resources.EndGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.victoriousLabel);
            this.Controls.Add(this.loserLabel);
            this.Controls.Add(this.btn_ExitGame);
            this.Name = "ExitGameState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadEndGameInfo()
        {
            if (this.CommandDispatcher.Database.Player.HealthPoints > 0)
            {
                this.victoriousLabel.Visible = true;
            }
            else
            {
                this.loserLabel.Visible = true;
            }
        }

        private void OnExitGameButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}