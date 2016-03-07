namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;
    using HeroesFight.Utilities;

    #endregion

    public class StartGameState : State
    {
        public StartGameState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; private set; }

        public Button ContinueButton { get; private set; }

        public Label EnterYourNameLabel { get; private set; }

        public Button ExitGameButton { get; private set; }

        public TextBox PlayerNameTextBox { get; private set; }

        public Button StartGameButton { get; private set; }

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

        private void InitializeComponent()
        {
            this.StartGameButton = new Button();
            this.EnterYourNameLabel = new Label();
            this.PlayerNameTextBox = new TextBox();
            this.ContinueButton = new Button();
            this.ExitGameButton = new Button();
            this.SuspendLayout();

            // StartGameButton
            this.StartGameButton.Location = new Point(324, 200);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new Size(117, 27);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start game";
            this.StartGameButton.UseVisualStyleBackColor = true;

            // lbl_EnterYourName
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204);
            this.EnterYourNameLabel.Location = new Point(324, 267);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new Size(117, 17);
            this.EnterYourNameLabel.TabIndex = 2;
            this.EnterYourNameLabel.Text = "Enter your name:";

            // txtBox_PlayerName
            this.PlayerNameTextBox.Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204);
            this.PlayerNameTextBox.Location = new Point(322, 294);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new Size(119, 23);
            this.PlayerNameTextBox.TabIndex = 3;
            this.PlayerNameTextBox.TextAlign = HorizontalAlignment.Center;

            // btn_Continue
            this.ContinueButton.Location = new Point(322, 323);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new Size(119, 27);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;

            // btn_ExitGame
            this.ExitGameButton.Location = new Point(324, 233);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new Size(117, 27);
            this.ExitGameButton.TabIndex = 5;
            this.ExitGameButton.Text = "Exit";
            this.ExitGameButton.UseVisualStyleBackColor = true;

            // State
            this.BackgroundImage = Resources.StartGameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(793, 584);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Controls.Add(this.StartGameButton);
            this.DoubleBuffered = true;
            this.Name = "StartGameState";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += this.HeroesFightStartState_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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