namespace HeroesFight.States
{
    #region

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;

    #endregion

    public class FirstLevelRoundThreeState : State
    {
        private readonly IEnemy currentEnemy;
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
        private ToolTip playerTooltip;
        private IContainer components;
        private ToolTip enemyTooltip;
        private ToolTip firstMagicTooltip;
        private ToolTip secondMagicTooltip;
        private ToolTip thirdMagicTooltip;
        private ToolTip fourthMagicTooltip;
        private PictureBox thirdSpellPictureBox;

        public FirstLevelRoundThreeState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
            this.currentEnemy = this.CommandDispatcher.Database.GetCurrentLevelEnemy();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        public override void Update()
        {
            this.UpdateHeroesGameInfo();

            this.Draw();
        }

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

            this.UpdateHeroesGameInfo();

            this.UpdateMagicsGameInfo();
        }

        private void DrawEnemyInfo(Graphics graphics)
        {
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
                $"{this.currentEnemy.Name}",
                new Font(FontFamily.GenericMonospace, 18),
                new SolidBrush(Color.SlateGray),
                500,
                20);

            this.enemyHpLabel.Text = this.currentEnemy.HealthPoints.ToString();
            this.enemyManaLabel.Text = this.currentEnemy.ManaPoints.ToString();
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

            this.firstSpellPictureBox.Image = (database.GetPlayerMagicById(0) as GameObject).Sprite;
            this.firstSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.secondSpellPicturebox.Image = (database.GetPlayerMagicById(1) as GameObject).Sprite;
            this.secondSpellPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.thirdSpellPictureBox.Image = (database.GetPlayerMagicById(2) as GameObject).Sprite;
            this.thirdSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.fourthMagicPictureBox.Image = (database.GetPlayerMagicById(3) as GameObject).Sprite;
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

        private void OnFirstMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "firstMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);

            if (this.currentEnemy.HealthPoints > 0)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnFourthMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "fourthMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);
            if (this.currentEnemy.HealthPoints > 0)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnSecondSpellClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);
            if (this.currentEnemy.HealthPoints > 0)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnThirdMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "thirdMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);

            if (this.currentEnemy.HealthPoints > 0)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void UpdateHeroesGameInfo()
        {
            IEnemy enemy = this.CommandDispatcher.Database.GetCurrentLevelEnemy();
            string enemyInfo = "Cruel and powerful this is how you describe the leader of the Bloodline clan.\n"
                               + (enemy as Hero).ToString();
            this.enemyTooltip.SetToolTip(this.enemyPictureBox, enemyInfo);

            IPlayer player = this.CommandDispatcher.Database.Player;
            this.playerTooltip.SetToolTip(this.playerPictureBox, (player as Hero).ToString());
        }

        private void UpdateMagicsGameInfo()
        {
            IMagic firstMagic = this.CommandDispatcher.Database.GetPlayerMagicById(0);
            this.firstMagicTooltip.SetToolTip(this.firstSpellPictureBox, (firstMagic as Magic).ToString());

            IMagic secondMagic = this.CommandDispatcher.Database.GetPlayerMagicById(1);
            this.secondMagicTooltip.SetToolTip(this.secondSpellPicturebox, (secondMagic as Magic).ToString());

            IMagic thirdMagic = this.CommandDispatcher.Database.GetPlayerMagicById(2);
            this.thirdMagicTooltip.SetToolTip(this.thirdSpellPictureBox, (thirdMagic as Magic).ToString());

            IMagic fourhtMagic = this.CommandDispatcher.Database.GetPlayerMagicById(3);
            this.fourthMagicTooltip.SetToolTip(this.fourthMagicPictureBox, (fourhtMagic as Magic).ToString());
        }

        #region
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.playerTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.enemyTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.firstMagicTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.secondMagicTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.thirdMagicTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fourthMagicTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firstSpellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSpellPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdSpellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthMagicPictureBox)).BeginInit();
            this.SuspendLayout();
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
        #endregion
    }
}