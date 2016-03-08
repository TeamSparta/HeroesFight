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
        public Button ContinueButton;

        public Label EnterYourNameLabel;

        public Button ExitGameButton;

        public TextBox PlayerNameTextBox;

        public Button StartGameButton;

        public StartGameState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.OnExitButtonClick(null, e);
        }

        private void HeroesFightStartState_Load(object sender, EventArgs e)
        {
            this.EnterYourNameLabel.Visible = false;
            this.PlayerNameTextBox.Visible = false;
            this.ContinueButton.Visible = false;

            this.StartGameButton.Click += this.OnStartGameButtonClick;
            this.ExitGameButton.Click += this.OnExitButtonClick;
            this.ContinueButton.Click += this.OnContinueButtonClick;
        }

#region
        private void InitializeComponent()
        {
            this.StartGameButton = new System.Windows.Forms.Button();
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(324, 200);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(117, 27);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start game!";
            this.StartGameButton.UseVisualStyleBackColor = true;
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterYourNameLabel.Location = new System.Drawing.Point(324, 267);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(117, 17);
            this.EnterYourNameLabel.TabIndex = 2;
            this.EnterYourNameLabel.Text = "Enter your name:";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(322, 294);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(119, 23);
            this.PlayerNameTextBox.TabIndex = 3;
            this.PlayerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(322, 323);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(119, 27);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Location = new System.Drawing.Point(324, 233);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(117, 27);
            this.ExitGameButton.TabIndex = 5;
            this.ExitGameButton.Text = "Exit";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            // 
            // StartGameState
            // 
            this.BackgroundImage = global::HeroesFight.Properties.Resources.StartGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Controls.Add(this.StartGameButton);
            this.DoubleBuffered = true;
            this.Name = "StartGameState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HeroesFightStartState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private void OnContinueButtonClick(object sender, EventArgs e)
        {
            string playerName = this.PlayerNameTextBox.Text;
            Regex nameRegex = new Regex(@"^\w{3,20}$");
            if (!nameRegex.IsMatch(playerName))
            {
                MessageBox.Show(
                    @"Name should be between 3 and 20 characters long and should consist only of letters and digits. Please try again!");
                this.PlayerNameTextBox.Clear();
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
    }
}