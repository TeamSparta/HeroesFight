namespace HeroesFight
{
    public partial class HeroesFightStartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExitGame;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.Lbl_EnterYourName = new System.Windows.Forms.Label();
            this.TxtBox_PlayerName = new System.Windows.Forms.TextBox();
            this.Btn_ConitueToPickClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(365, 246);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.OnStartGameButtonClick);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(365, 334);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(75, 23);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.Text = "Exit";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // Lbl_EnterYourName
            // 
            this.Lbl_EnterYourName.AutoSize = true;
            this.Lbl_EnterYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_EnterYourName.Location = new System.Drawing.Point(357, 272);
            this.Lbl_EnterYourName.Name = "Lbl_EnterYourName";
            this.Lbl_EnterYourName.Size = new System.Drawing.Size(96, 15);
            this.Lbl_EnterYourName.TabIndex = 2;
            this.Lbl_EnterYourName.Text = "Enter you name:";
            this.Lbl_EnterYourName.Visible = false;
            this.Lbl_EnterYourName.Click += new System.EventHandler(this.OnPickNameLabelClick);
            // 
            // TxtBox_PlayerName
            // 
            this.TxtBox_PlayerName.Location = new System.Drawing.Point(355, 290);
            this.TxtBox_PlayerName.Name = "TxtBox_PlayerName";
            this.TxtBox_PlayerName.Size = new System.Drawing.Size(98, 20);
            this.TxtBox_PlayerName.TabIndex = 3;
            this.TxtBox_PlayerName.Visible = false;
            this.TxtBox_PlayerName.TextChanged += new System.EventHandler(this.OnNameTextBoxChange);
            // 
            // Btn_ConitueToPickClass
            // 
            this.Btn_ConitueToPickClass.Location = new System.Drawing.Point(365, 316);
            this.Btn_ConitueToPickClass.Name = "Btn_ConitueToPickClass";
            this.Btn_ConitueToPickClass.Size = new System.Drawing.Size(75, 23);
            this.Btn_ConitueToPickClass.TabIndex = 4;
            this.Btn_ConitueToPickClass.Text = "Continue";
            this.Btn_ConitueToPickClass.UseVisualStyleBackColor = true;
            this.Btn_ConitueToPickClass.Visible = false;
            this.Btn_ConitueToPickClass.Click += new System.EventHandler(this.OnContinueButtonClick);
            // 
            // HeroesFightStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.StartGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 576);
            this.Controls.Add(this.Btn_ConitueToPickClass);
            this.Controls.Add(this.TxtBox_PlayerName);
            this.Controls.Add(this.Lbl_EnterYourName);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnStartGame);
            this.DoubleBuffered = true;
            this.Name = "HeroesFightStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroesFightForm";
            this.Load += new System.EventHandler(this.HeroesFightStartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_EnterYourName;
        private System.Windows.Forms.TextBox TxtBox_PlayerName;
        private System.Windows.Forms.Button Btn_ConitueToPickClass;
    }
}
