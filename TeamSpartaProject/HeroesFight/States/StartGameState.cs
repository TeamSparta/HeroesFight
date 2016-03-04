namespace HeroesFight.States
{
    using System;
    using System.Windows.Forms;

    using Interfaces;
    using Utilities;

    public class StartGameState : State
    {
        private Button btn_StartGame;
        private TextBox txtBox_PlayerName;
        private Button btn_Continue;
        private Button btn_ExitGame;
        private Label lbl_EnterYourName;


        public StartGameState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; private set; }

        public Button StartGameButton => this.btn_StartGame;

        public TextBox PlayerNameTextBox => this.txtBox_PlayerName;

        public Button ContinueButton => this.btn_Continue;

        public Button ExitGameButton => this.btn_ExitGame;

        public Label EnterYourNameLabel => this.lbl_EnterYourName;

        #region
        private void InitializeComponent()
        {
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.lbl_EnterYourName = new System.Windows.Forms.Label();
            this.txtBox_PlayerName = new System.Windows.Forms.TextBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_ExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(324, 200);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(117, 27);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.OnStartGameButtonClick);
            // 
            // lbl_EnterYourName
            // 
            this.lbl_EnterYourName.AutoSize = true;
            this.lbl_EnterYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_EnterYourName.Location = new System.Drawing.Point(324, 267);
            this.lbl_EnterYourName.Name = "lbl_EnterYourName";
            this.lbl_EnterYourName.Size = new System.Drawing.Size(117, 17);
            this.lbl_EnterYourName.TabIndex = 2;
            this.lbl_EnterYourName.Text = "Enter your name:";
            // 
            // txtBox_PlayerName
            // 
            this.txtBox_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_PlayerName.Location = new System.Drawing.Point(322, 294);
            this.txtBox_PlayerName.Name = "txtBox_PlayerName";
            this.txtBox_PlayerName.Size = new System.Drawing.Size(119, 23);
            this.txtBox_PlayerName.TabIndex = 3;
            this.txtBox_PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(322, 323);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(119, 27);
            this.btn_Continue.TabIndex = 4;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // btn_ExitGame
            // 
            this.btn_ExitGame.Location = new System.Drawing.Point(324, 233);
            this.btn_ExitGame.Name = "btn_ExitGame";
            this.btn_ExitGame.Size = new System.Drawing.Size(117, 27);
            this.btn_ExitGame.TabIndex = 5;
            this.btn_ExitGame.Text = "Exit";
            this.btn_ExitGame.UseVisualStyleBackColor = true;
            // 
            // State
            // 
            this.BackgroundImage = global::HeroesFight.Properties.Resources.StartGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.btn_ExitGame);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.txtBox_PlayerName);
            this.Controls.Add(this.lbl_EnterYourName);
            this.Controls.Add(this.btn_StartGame);
            this.DoubleBuffered = true;
            this.Name = "StartGameState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HeroesFightStartState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            OnExitButtonClick(null, e);
        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand(Constants.EndGameCommandName, null);
        }

        private void OnContinueButtonClick(object sender, EventArgs e)
        {
            string playerName = this.txtBox_PlayerName.Text;
            this.CommandDispatcher.ProcessCommand(Constants.LogUserNameCommandName, new object[] {playerName});
        }

        private void OnEnterNameLabelClick(object sender, EventArgs e)
        {
        }

        private void HeroesFightStartState_Load(object sender, EventArgs e)
        {
            this.lbl_EnterYourName.Visible = false;
            this.txtBox_PlayerName.Visible = false;
            this.btn_Continue.Visible = false;

            this.btn_StartGame.Click += this.OnStartGameButtonClick;
            this.btn_ExitGame.Click += this.OnExitButtonClick;
            this.lbl_EnterYourName.Click += this.OnEnterNameLabelClick;
            this.btn_Continue.Click += this.OnContinueButtonClick;
        }

        private void OnStartGameButtonClick(object sender, EventArgs e)
        {   
            this.CommandDispatcher.ProcessCommand(Constants.StartGameCommandName, null);
        }
    }
}
