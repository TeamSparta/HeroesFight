namespace HeroesFight
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public class HeroesFightStartState : Form
    {
        private Button btn_StartGame;
        private Button btn_ExitGame;
        private TextBox txtBox_PlayerName;
        private Label lbl_EnterYourName;

        public HeroesFightStartState(IDataBase dataBase)
        {
            this.DataBase = dataBase;
            this.InitializeComponent();
        }

        public IDataBase DataBase { get; }

        private void InitializeComponent()
        {
            this.btn_StartGame = new Button();
            this.btn_ExitGame = new Button();
            this.lbl_EnterYourName = new Label();
            this.txtBox_PlayerName = new TextBox();
            this.SuspendLayout();

            // btn_StartGame
            this.btn_StartGame.Location = new System.Drawing.Point(356, 217);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(67, 21);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start game";
            this.btn_StartGame.UseVisualStyleBackColor = true;

            // btn_ExitGame
            this.btn_ExitGame.Location = new System.Drawing.Point(356, 296);
            this.btn_ExitGame.Name = "btn_ExitGame";
            this.btn_ExitGame.Size = new System.Drawing.Size(67, 21);
            this.btn_ExitGame.TabIndex = 1;
            this.btn_ExitGame.Text = "Exit";
            this.btn_ExitGame.UseVisualStyleBackColor = true;
            this.btn_ExitGame.Click += this.OnExitButtonClick;

            // lbl_EnterYourName
            this.lbl_EnterYourName.AutoSize = true;
            this.lbl_EnterYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_EnterYourName.Location = new System.Drawing.Point(336, 241);
            this.lbl_EnterYourName.Name = "lbl_EnterYourName";
            this.lbl_EnterYourName.Size = new System.Drawing.Size(117, 17);
            this.lbl_EnterYourName.TabIndex = 2;
            this.lbl_EnterYourName.Text = "Enter your name:";
            this.lbl_EnterYourName.Click += this.OnEnterNameLabelClick;

            // txtBox_PlayerName
            this.txtBox_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_PlayerName.Location = new System.Drawing.Point(334, 268);
            this.txtBox_PlayerName.Name = "txtBox_PlayerName";
            this.txtBox_PlayerName.Size = new System.Drawing.Size(118, 23);
            this.txtBox_PlayerName.TabIndex = 3;
            this.txtBox_PlayerName.TextChanged += this.OnContinueButtonClick;

            // HeroesFightStartState
            this.BackgroundImage = Properties.Resources.StartGameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.txtBox_PlayerName);
            this.Controls.Add(this.lbl_EnterYourName);
            this.Controls.Add(this.btn_ExitGame);
            this.Controls.Add(this.btn_StartGame);
            this.DoubleBuffered = true;
            this.Name = "HeroesFightStartState";
            this.Load += this.OnStateLoad;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void OnStateLoad(object sender, EventArgs e)
        {
        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnContinueButtonClick(object sender, EventArgs e)
        {

            string playerName = this.txtBox_PlayerName.Text;

            // This logic have to be isolated.
            Regex nameRegex = new Regex(@"([\w]+){3,20}");

            if (!nameRegex.IsMatch(playerName))
            {
                MessageBox.Show(
                    "Name should be between 3 and 20 characters long and should consist only letters and digits. Please try again!");
                this.txtBox_PlayerName.Clear();
            }
            else
            {
                this.DataBase.PlayerName = playerName;
                this.Hide();
                SelectCharacterForm.Instance.Show();
            }
        }

        private void OnEnterNameLabelClick(object sender, EventArgs e)
        {
        }
    }
}
