namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.Properties;
    using HeroesFight.Utilities;

    #endregion

    public class StartGameState : State
    {
        private Button continueButton;

        private Label enterYourNameLabel;

        private Button exitGameButton;

        private TextBox playerNameTextBox;

        private Button startGameButton;

        public StartGameState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        public override void Initialize()
        {
            this.startGameButton.Visible = false;
            this.exitGameButton.Visible = false;

            this.enterYourNameLabel.Visible = true;
            this.playerNameTextBox.Visible = true;
            this.continueButton.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.OnExitButtonClick(null, e);
        }

        private void HeroesFightStartState_Load(object sender, EventArgs e)
        {
            this.enterYourNameLabel.Visible = false;
            this.playerNameTextBox.Visible = false;
            this.continueButton.Visible = false;

            this.startGameButton.Click += this.OnStartGameButtonClick;
            this.exitGameButton.Click += this.OnExitButtonClick;
            this.continueButton.Click += this.OnContinueButtonClick;
        }

        private void OnContinueButtonClick(object sender, EventArgs e)
        {
            string playerName = this.playerNameTextBox.Text;
            Regex nameRegex = new Regex(@"^\w{3,20}$");
            if (!nameRegex.IsMatch(playerName))
            {
                MessageBox.Show(
                    @"Name should be between 3 and 20 characters long and should consist only of letters and digits. Please try again!");
                this.playerNameTextBox.Clear();
                return;
            }

            this.CommandDispatcher.ProcessCommand(Constants.LogUserNameCommandName, new object[] { playerName });
        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand(Constants.EndGameCommandName, null);
        }

        private void OnStartGameButtonClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand(Constants.StartGameCommandName, null);
        }

        #region
        private void InitializeComponent()
        {
            this.startGameButton = new System.Windows.Forms.Button();
            this.enterYourNameLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(324, 200);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(117, 27);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start game!";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // enterYourNameLabel
            // 
            this.enterYourNameLabel.AutoSize = true;
            this.enterYourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterYourNameLabel.Location = new System.Drawing.Point(324, 267);
            this.enterYourNameLabel.Name = "enterYourNameLabel";
            this.enterYourNameLabel.Size = new System.Drawing.Size(117, 17);
            this.enterYourNameLabel.TabIndex = 2;
            this.enterYourNameLabel.Text = "Enter your name:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameTextBox.Location = new System.Drawing.Point(322, 294);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(119, 23);
            this.playerNameTextBox.TabIndex = 3;
            this.playerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(322, 323);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(119, 27);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(324, 233);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(117, 27);
            this.exitGameButton.TabIndex = 5;
            this.exitGameButton.Text = "Exit";
            this.exitGameButton.UseVisualStyleBackColor = true;
            // 
            // StartGameState
            // 
            this.BackgroundImage = global::HeroesFight.Properties.Resources.StartGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.enterYourNameLabel);
            this.Controls.Add(this.startGameButton);
            this.DoubleBuffered = true;
            this.Name = "StartGameState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HeroesFightStartState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}