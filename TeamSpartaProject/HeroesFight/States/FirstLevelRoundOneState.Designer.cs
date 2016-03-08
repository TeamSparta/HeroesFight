namespace HeroesFight.States
{
    partial class FirstLevelRoundOneState
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.firstSpellPictureBox = new System.Windows.Forms.PictureBox();
            this.secondSpellPictureox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.playerManaLabel = new System.Windows.Forms.Label();
            this.playerHpLabel = new System.Windows.Forms.Label();
            this.enemyHpLabel = new System.Windows.Forms.Label();
            this.enemyManaLabel = new System.Windows.Forms.Label();
            this.playerAttackInfoLabel = new System.Windows.Forms.Label();
            this.enemyAttackInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstSpellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSpellPictureox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.Location = new System.Drawing.Point(342, 246);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.Btn_Attack.TabIndex = 0;
            this.Btn_Attack.Text = "Battle!";
            this.Btn_Attack.UseVisualStyleBackColor = true;
            this.Btn_Attack.Click += new System.EventHandler(this.OnBattleButtonClick);
            // 
            // firstSpellPictureBox
            // 
            this.firstSpellPictureBox.Location = new System.Drawing.Point(60, 494);
            this.firstSpellPictureBox.Name = "firstSpellPictureBox";
            this.firstSpellPictureBox.Size = new System.Drawing.Size(40, 40);
            this.firstSpellPictureBox.TabIndex = 1;
            this.firstSpellPictureBox.TabStop = false;
            this.firstSpellPictureBox.Click += new System.EventHandler(this.OnFirstMagicClick);
            // 
            // secondSpellPicturebox
            // 
            this.secondSpellPictureox.Location = new System.Drawing.Point(106, 494);
            this.secondSpellPictureox.Name = "secondSpellPictureox";
            this.secondSpellPictureox.Size = new System.Drawing.Size(40, 40);
            this.secondSpellPictureox.TabIndex = 2;
            this.secondSpellPictureox.TabStop = false;
            this.secondSpellPictureox.Click += new System.EventHandler(this.OnSecondMagicClick);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.Location = new System.Drawing.Point(60, 139);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(169, 316);
            this.playerPictureBox.TabIndex = 3;
            this.playerPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.Location = new System.Drawing.Point(574, 139);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(169, 316);
            this.enemyPictureBox.TabIndex = 4;
            this.enemyPictureBox.TabStop = false;
            // 
            // playerManaLabel
            // 
            this.playerManaLabel.AutoSize = true;
            this.playerManaLabel.BackColor = System.Drawing.Color.Blue;
            this.playerManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerManaLabel.ForeColor = System.Drawing.Color.Snow;
            this.playerManaLabel.Location = new System.Drawing.Point(120, 81);
            this.playerManaLabel.Name = "playerManaLabel";
            this.playerManaLabel.Size = new System.Drawing.Size(117, 17);
            this.playerManaLabel.TabIndex = 6;
            this.playerManaLabel.Text = "playerManaLabel";
            this.playerManaLabel.Visible = false;
            // 
            // playerHpLabel
            // 
            this.playerHpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHpLabel.AutoSize = true;
            this.playerHpLabel.BackColor = System.Drawing.Color.Red;
            this.playerHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerHpLabel.ForeColor = System.Drawing.Color.Snow;
            this.playerHpLabel.Location = new System.Drawing.Point(103, 57);
            this.playerHpLabel.Name = "playerHpLabel";
            this.playerHpLabel.Size = new System.Drawing.Size(100, 17);
            this.playerHpLabel.TabIndex = 7;
            this.playerHpLabel.Text = "playerHpLabel";
            this.playerHpLabel.Visible = false;
            // 
            // enemyHpLabel
            // 
            this.enemyHpLabel.AutoSize = true;
            this.enemyHpLabel.BackColor = System.Drawing.Color.Red;
            this.enemyHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyHpLabel.ForeColor = System.Drawing.Color.Snow;
            this.enemyHpLabel.Location = new System.Drawing.Point(530, 57);
            this.enemyHpLabel.Name = "enemyHpLabel";
            this.enemyHpLabel.Size = new System.Drawing.Size(103, 17);
            this.enemyHpLabel.TabIndex = 8;
            this.enemyHpLabel.Text = "enemyHpLabel";
            this.enemyHpLabel.Visible = false;
            // 
            // enemyManaLabel
            // 
            this.enemyManaLabel.AutoSize = true;
            this.enemyManaLabel.BackColor = System.Drawing.Color.Blue;
            this.enemyManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyManaLabel.ForeColor = System.Drawing.Color.Snow;
            this.enemyManaLabel.Location = new System.Drawing.Point(550, 81);
            this.enemyManaLabel.Name = "enemyManaLabel";
            this.enemyManaLabel.Size = new System.Drawing.Size(120, 17);
            this.enemyManaLabel.TabIndex = 9;
            this.enemyManaLabel.Text = "enemyManaLabel";
            this.enemyManaLabel.Visible = false;
            // 
            // playerAttackInfoLabel
            // 
            this.playerAttackInfoLabel.AutoSize = true;
            this.playerAttackInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerAttackInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerAttackInfoLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.playerAttackInfoLabel.Location = new System.Drawing.Point(235, 301);
            this.playerAttackInfoLabel.Name = "playerAttackInfoLabel";
            this.playerAttackInfoLabel.Size = new System.Drawing.Size(45, 16);
            this.playerAttackInfoLabel.TabIndex = 10;
            this.playerAttackInfoLabel.Text = "label1";
            this.playerAttackInfoLabel.Visible = false;
            // 
            // enemyAttackInfoLabel
            // 
            this.enemyAttackInfoLabel.AutoSize = true;
            this.enemyAttackInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyAttackInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyAttackInfoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.enemyAttackInfoLabel.Location = new System.Drawing.Point(235, 223);
            this.enemyAttackInfoLabel.Name = "enemyAttackInfoLabel";
            this.enemyAttackInfoLabel.Size = new System.Drawing.Size(45, 16);
            this.enemyAttackInfoLabel.TabIndex = 11;
            this.enemyAttackInfoLabel.Text = "label1";
            this.enemyAttackInfoLabel.Visible = false;
            // 
            // FirstLevelRoundOneState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::HeroesFight.Properties.Resources.LevelOneBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.enemyAttackInfoLabel);
            this.Controls.Add(this.playerAttackInfoLabel);
            this.Controls.Add(this.enemyManaLabel);
            this.Controls.Add(this.enemyHpLabel);
            this.Controls.Add(this.playerHpLabel);
            this.Controls.Add(this.playerManaLabel);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.secondSpellPictureox);
            this.Controls.Add(this.firstSpellPictureBox);
            this.Controls.Add(this.Btn_Attack);
            this.Name = "FirstLevelRoundOneState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstLevelForm";
            this.Load += new System.EventHandler(this.FirstLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstSpellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSpellPictureox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Attack;
        public System.Windows.Forms.PictureBox firstSpellPictureBox;
        public System.Windows.Forms.PictureBox secondSpellPictureox;
        public System.Windows.Forms.PictureBox playerPictureBox;
        public System.Windows.Forms.PictureBox enemyPictureBox;
        public System.Windows.Forms.Label playerHpLabel;
        public System.Windows.Forms.Label playerManaLabel;
        public System.Windows.Forms.Label enemyHpLabel;
        public System.Windows.Forms.Label enemyManaLabel;
        public System.Windows.Forms.Label playerAttackInfoLabel;
        public System.Windows.Forms.Label enemyAttackInfoLabel;
    }
}