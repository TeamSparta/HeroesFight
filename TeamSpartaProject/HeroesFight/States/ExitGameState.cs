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

        private Label lbl_EndGameResult;

        public ExitGameState(ICommandDispatcher commandDispatcher)
        {
            this.InitializeComponent();
            this.CommandDispatcher = commandDispatcher;
            this.LoadEndGameInfo();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        private void ExitGameState_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.btn_ExitGame = new Button();
            this.lbl_EndGameResult = new Label();
            this.SuspendLayout();

            // btn_ExitGame
            this.btn_ExitGame.Location = new Point(340, 284);
            this.btn_ExitGame.Name = "btn_ExitGame";
            this.btn_ExitGame.Size = new Size(96, 23);
            this.btn_ExitGame.TabIndex = 0;
            this.btn_ExitGame.Text = "Exit game";
            this.btn_ExitGame.UseVisualStyleBackColor = true;
            this.btn_ExitGame.Click += this.OnExitGameClick;

            // lbl_EndGameResult
            this.lbl_EndGameResult.AutoSize = true;
            this.lbl_EndGameResult.Font = new Font(
                "Microsoft Sans Serif", 
                10F, 
                FontStyle.Regular, 
                GraphicsUnit.Point, 
                204);
            this.lbl_EndGameResult.ForeColor = Color.DodgerBlue;
            this.lbl_EndGameResult.Location = new Point(306, 220);
            this.lbl_EndGameResult.Name = "lbl_EndGameResult";
            this.lbl_EndGameResult.Size = new Size(46, 17);
            this.lbl_EndGameResult.TabIndex = 1;
            this.lbl_EndGameResult.Text = "label1";

            // ExitGameState
            this.BackgroundImage = Resources.EndGameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(793, 584);
            this.Controls.Add(this.lbl_EndGameResult);
            this.Controls.Add(this.btn_ExitGame);
            this.Name = "ExitGameState";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += this.ExitGameState_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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

        private void OnExitGameClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}