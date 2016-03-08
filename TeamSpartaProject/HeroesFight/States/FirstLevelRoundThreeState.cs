﻿namespace HeroesFight.States
{
    #region

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class FirstLevelRoundThreeState : State
    {
        private Label enemyAttackInfoLabel;
        private Label enemyHpLabel;
        private Label enemyManaLabel;
        private PictureBox enemyPictureBox;
        private PictureBox firstSpellPictureBox;
        private PictureBox fourthMagicPictureBox;
        private Label playerAttackInfoLabel;
        private Label playerHpLabel;
        private Label playerManaLabel;
        private PictureBox playerPictureBox;
        private PictureBox secondSpellPicturebox;
        private PictureBox thirdSpellPictureBox;
        private Button Btn_Attack;

        public FirstLevelRoundThreeState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        public override void Draw()
        {
            var graphics = this.CreateGraphics();

            this.DrawPlayerInfo(graphics);

            this.DrawEnemyInfo(graphics);
        }

        public override void Initialize()
        {
            this.LoadImages();

            this.Draw();

            this.SetVisibility();
        }

        private void DrawEnemyInfo(Graphics graphics)
        {
            var enemy = this.CommandDispatcher.Database.GetCurrentLevelEnemy();

            Rectangle hpBarRectangle = new Rectangle(493, 55, 250, 20);
            Rectangle manaBarRectangle = new Rectangle(493, 80, 250, 20);

            graphics.FillRectangle(new SolidBrush(Color.Red), hpBarRectangle);
            graphics.FillRectangle(new SolidBrush(Color.Blue), manaBarRectangle);

            graphics.DrawRectangle(new Pen(Color.Black), hpBarRectangle);
            graphics.DrawRectangle(new Pen(Color.Black), manaBarRectangle);

            graphics.DrawString(
                "HP:",
                new Font(FontFamily.GenericMonospace, 12),
                new SolidBrush(Color.DarkGray),
                500,
                57);
            graphics.DrawString(
                "Mana:",
                new Font(FontFamily.GenericMonospace, 12),
                new SolidBrush(Color.DarkGray),
                500,
                81);

            graphics.DrawString(
                $"{enemy.Name}",
                new Font(FontFamily.GenericMonospace, 18),
                new SolidBrush(Color.SlateGray),
                500,
                20);

            this.enemyHpLabel.Text = enemy.HealthPoints.ToString();
            this.enemyManaLabel.Text = enemy.ManaPoints.ToString();
        }

        private void DrawPlayerInfo(Graphics graphics)
        {
            Rectangle hpBarRectangle = new Rectangle(60, 55, 250, 20);
            Rectangle manaBarRectangle = new Rectangle(60, 80, 250, 20);

            graphics.FillRectangle(new SolidBrush(Color.Red), hpBarRectangle);
            graphics.FillRectangle(new SolidBrush(Color.Blue), manaBarRectangle);

            graphics.DrawRectangle(new Pen(Color.Black), hpBarRectangle);
            graphics.DrawRectangle(new Pen(Color.Black), manaBarRectangle);

            graphics.DrawString(
                "HP:",
                new Font(FontFamily.GenericMonospace, 12),
                new SolidBrush(Color.DarkGray),
                70,
                57);
            graphics.DrawString(
                "Mana:",
                new Font(FontFamily.GenericMonospace, 12),
                new SolidBrush(Color.DarkGray),
                70,
                81);

            graphics.DrawString(
                $"{this.CommandDispatcher.Database.PlayerName}",
                new Font(FontFamily.GenericMonospace, 18),
                new SolidBrush(Color.Black),
                60,
                20);

            this.playerHpLabel.Text = this.CommandDispatcher.Database.Player.HealthPoints.ToString();
            this.playerManaLabel.Text = this.CommandDispatcher.Database.Player.ManaPoints.ToString();
        }

        private void SetVisibility()
        {
            this.playerHpLabel.Visible = true;
            this.playerManaLabel.Visible = true;
            this.enemyHpLabel.Visible = true;
            this.enemyManaLabel.Visible = true;
            this.playerPictureBox.Visible = true;
            this.enemyPictureBox.Visible = true;
            this.firstSpellPictureBox.Visible = true;
            this.secondSpellPicturebox.Visible = true;
            this.thirdSpellPictureBox.Visible = true;
            this.fourthMagicPictureBox.Visible = true;
        }

        private void LoadImages()
        {
            var database = this.CommandDispatcher.Database;

            this.enemyPictureBox.Image = (database.GetCurrentLevelEnemy() as GameObject).Sprite;
            this.enemyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.Image = (database.Player as GameObject).Sprite;
            this.playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.firstSpellPictureBox.Image = (database.GetCurrentMagicById(0) as GameObject).Sprite;
            this.firstSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.secondSpellPicturebox.Image = (database.GetCurrentMagicById(1) as GameObject).Sprite;
            this.secondSpellPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.thirdSpellPictureBox.Image = (database.GetCurrentMagicById(2) as GameObject).Sprite;
            this.thirdSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.fourthMagicPictureBox.Image = (database.GetCurrentMagicById(3) as GameObject).Sprite;
            this.fourthMagicPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FirstLevelRoundThreeState_Load(object sender, EventArgs e)
        {
            this.playerPictureBox.Visible = false;
            this.enemyPictureBox.Visible = false;

            this.firstSpellPictureBox.Visible = false;
            this.firstSpellPictureBox.Click += this.OnFirstMagicClick;

            this.secondSpellPicturebox.Visible = false;
            this.secondSpellPicturebox.Click += this.OnSecondSpellClick;

            this.thirdSpellPictureBox.Visible = false;
            this.thirdSpellPictureBox.Click += this.OnThirdMagicClick;

            this.fourthMagicPictureBox.Visible = false;
            this.fourthMagicPictureBox.Click += this.OnFourthMagicClick;

            this.CommandDispatcher.ProcessCommand("Initialize", null);
        }

        private void InitializeComponent()
        {
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.firstSpellPictureBox = new System.Windows.Forms.PictureBox();
            this.secondSpellPicturebox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.playerManaLabel = new System.Windows.Forms.Label();
            this.playerHpLabel = new System.Windows.Forms.Label();
            this.enemyHpLabel = new System.Windows.Forms.Label();
            this.enemyManaLabel = new System.Windows.Forms.Label();
            this.playerAttackInfoLabel = new System.Windows.Forms.Label();
            this.enemyAttackInfoLabel = new System.Windows.Forms.Label();
            this.thirdSpellPictureBox = new System.Windows.Forms.PictureBox();
            this.fourthMagicPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstSpellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSpellPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdSpellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthMagicPictureBox)).BeginInit();
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
            // 
            // firstSpellPictureBox
            // 
            this.firstSpellPictureBox.Location = new System.Drawing.Point(60, 494);
            this.firstSpellPictureBox.Name = "firstSpellPictureBox";
            this.firstSpellPictureBox.Size = new System.Drawing.Size(40, 40);
            this.firstSpellPictureBox.TabIndex = 1;
            this.firstSpellPictureBox.TabStop = false;
            // 
            // secondSpellPicturebox
            // 
            this.secondSpellPicturebox.Location = new System.Drawing.Point(106, 494);
            this.secondSpellPicturebox.Name = "secondSpellPicturebox";
            this.secondSpellPicturebox.Size = new System.Drawing.Size(40, 40);
            this.secondSpellPicturebox.TabIndex = 2;
            this.secondSpellPicturebox.TabStop = false;
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
            // thirdSpellPictureBox
            // 
            this.thirdSpellPictureBox.Location = new System.Drawing.Point(152, 494);
            this.thirdSpellPictureBox.Name = "thirdSpellPictureBox";
            this.thirdSpellPictureBox.Size = new System.Drawing.Size(40, 40);
            this.thirdSpellPictureBox.TabIndex = 12;
            this.thirdSpellPictureBox.TabStop = false;
            // 
            // fourthMagicPictureBox
            // 
            this.fourthMagicPictureBox.Location = new System.Drawing.Point(198, 494);
            this.fourthMagicPictureBox.Name = "fourthMagicPictureBox";
            this.fourthMagicPictureBox.Size = new System.Drawing.Size(40, 40);
            this.fourthMagicPictureBox.TabIndex = 13;
            this.fourthMagicPictureBox.TabStop = false;
            // 
            // FirstLevelRoundThreeState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::HeroesFight.Properties.Resources.LevelOneBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.fourthMagicPictureBox);
            this.Controls.Add(this.thirdSpellPictureBox);
            this.Controls.Add(this.enemyAttackInfoLabel);
            this.Controls.Add(this.playerAttackInfoLabel);
            this.Controls.Add(this.enemyManaLabel);
            this.Controls.Add(this.enemyHpLabel);
            this.Controls.Add(this.playerHpLabel);
            this.Controls.Add(this.playerManaLabel);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.secondSpellPicturebox);
            this.Controls.Add(this.firstSpellPictureBox);
            this.Controls.Add(this.Btn_Attack);
            this.Name = "FirstLevelRoundThreeState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstLevelForm";
            this.Load += new System.EventHandler(this.FirstLevelRoundThreeState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstSpellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSpellPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdSpellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthMagicPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OnFirstMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "firstMagic" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnFourthMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "fourthMagic" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnThirdMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "thirdMagic" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }
    }
}