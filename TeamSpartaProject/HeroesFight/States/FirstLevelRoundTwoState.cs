namespace HeroesFight.States
{
    #region

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class FirstLevelRoundTwoState : State
    {
        public Label enemyAttackInfoLabel;

        public Label enemyHpLabel;

        public Label enemyManaLabel;

        public PictureBox enemyPictureBox;

        public PictureBox firstSpellPictureBox;

        public Label playerAttackInfoLabel;

        public Label playerHpLabel;

        public Label playerManaLabel;

        public PictureBox playerPictureBox;

        public PictureBox secondSpellPictureox;

        public PictureBox thirdSpellPictureBox;

        private Button Btn_Attack;

        public FirstLevelRoundTwoState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
        }

        public ICommandDispatcher CommandDispatcher { get; }

        private void FirstLevelRoundThreeState_Load(object sender, EventArgs e)
        {
            this.playerPictureBox.Visible = false;
            this.enemyPictureBox.Visible = false;
            this.firstSpellPictureBox.Visible = false;
            this.secondSpellPictureox.Visible = false;
            this.thirdSpellPictureBox.Visible = false;

            this.CommandDispatcher.ProcessCommand("InitializeLevelTwo", null);
        }

        private void InitializeComponent()
        {
            this.Btn_Attack = new Button();
            this.firstSpellPictureBox = new PictureBox();
            this.secondSpellPictureox = new PictureBox();
            this.playerPictureBox = new PictureBox();
            this.enemyPictureBox = new PictureBox();
            this.playerManaLabel = new Label();
            this.playerHpLabel = new Label();
            this.enemyHpLabel = new Label();
            this.enemyManaLabel = new Label();
            this.playerAttackInfoLabel = new Label();
            this.enemyAttackInfoLabel = new Label();
            this.thirdSpellPictureBox = new PictureBox();
            ((ISupportInitialize)this.firstSpellPictureBox).BeginInit();
            ((ISupportInitialize)this.secondSpellPictureox).BeginInit();
            ((ISupportInitialize)this.playerPictureBox).BeginInit();
            ((ISupportInitialize)this.enemyPictureBox).BeginInit();
            ((ISupportInitialize)this.thirdSpellPictureBox).BeginInit();
            this.SuspendLayout();

            // Btn_Attack
            this.Btn_Attack.Location = new Point(342, 246);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new Size(75, 23);
            this.Btn_Attack.TabIndex = 0;
            this.Btn_Attack.Text = "Battle!";
            this.Btn_Attack.UseVisualStyleBackColor = true;

            // firstSpellPictureBox
            this.firstSpellPictureBox.Location = new Point(60, 494);
            this.firstSpellPictureBox.Name = "firstSpellPictureBox";
            this.firstSpellPictureBox.Size = new Size(40, 40);
            this.firstSpellPictureBox.TabIndex = 1;
            this.firstSpellPictureBox.TabStop = false;
            this.firstSpellPictureBox.Click += this.OnFirstMagicClick;

            // secondSpellPictureox
            this.secondSpellPictureox.Location = new Point(106, 494);
            this.secondSpellPictureox.Name = "secondSpellPictureox";
            this.secondSpellPictureox.Size = new Size(40, 40);
            this.secondSpellPictureox.TabIndex = 2;
            this.secondSpellPictureox.TabStop = false;
            this.secondSpellPictureox.Click += this.OnSecondSpellClick;

            // playerPictureBox
            this.playerPictureBox.BackColor = Color.Transparent;
            this.playerPictureBox.Location = new Point(60, 139);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new Size(169, 316);
            this.playerPictureBox.TabIndex = 3;
            this.playerPictureBox.TabStop = false;

            // enemyPictureBox
            this.enemyPictureBox.BackColor = Color.Transparent;
            this.enemyPictureBox.Location = new Point(574, 139);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new Size(169, 316);
            this.enemyPictureBox.TabIndex = 4;
            this.enemyPictureBox.TabStop = false;

            // playerManaLabel
            this.playerManaLabel.AutoSize = true;
            this.playerManaLabel.BackColor = Color.Blue;
            this.playerManaLabel.Font = new Font(
                "Microsoft Sans Serif", 
                10F, 
                FontStyle.Regular, 
                GraphicsUnit.Point, 
                204);
            this.playerManaLabel.ForeColor = Color.Snow;
            this.playerManaLabel.Location = new Point(120, 81);
            this.playerManaLabel.Name = "playerManaLabel";
            this.playerManaLabel.Size = new Size(117, 17);
            this.playerManaLabel.TabIndex = 6;
            this.playerManaLabel.Text = "playerManaLabel";
            this.playerManaLabel.Visible = false;

            // playerHpLabel
            this.playerHpLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.playerHpLabel.AutoSize = true;
            this.playerHpLabel.BackColor = Color.Red;
            this.playerHpLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.playerHpLabel.ForeColor = Color.Snow;
            this.playerHpLabel.Location = new Point(103, 57);
            this.playerHpLabel.Name = "playerHpLabel";
            this.playerHpLabel.Size = new Size(100, 17);
            this.playerHpLabel.TabIndex = 7;
            this.playerHpLabel.Text = "playerHpLabel";
            this.playerHpLabel.Visible = false;

            // enemyHpLabel
            this.enemyHpLabel.AutoSize = true;
            this.enemyHpLabel.BackColor = Color.Red;
            this.enemyHpLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.enemyHpLabel.ForeColor = Color.Snow;
            this.enemyHpLabel.Location = new Point(530, 57);
            this.enemyHpLabel.Name = "enemyHpLabel";
            this.enemyHpLabel.Size = new Size(103, 17);
            this.enemyHpLabel.TabIndex = 8;
            this.enemyHpLabel.Text = "enemyHpLabel";
            this.enemyHpLabel.Visible = false;

            // enemyManaLabel
            this.enemyManaLabel.AutoSize = true;
            this.enemyManaLabel.BackColor = Color.Blue;
            this.enemyManaLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.enemyManaLabel.ForeColor = Color.Snow;
            this.enemyManaLabel.Location = new Point(550, 81);
            this.enemyManaLabel.Name = "enemyManaLabel";
            this.enemyManaLabel.Size = new Size(120, 17);
            this.enemyManaLabel.TabIndex = 9;
            this.enemyManaLabel.Text = "enemyManaLabel";
            this.enemyManaLabel.Visible = false;

            // playerAttackInfoLabel
            this.playerAttackInfoLabel.AutoSize = true;
            this.playerAttackInfoLabel.BackColor = Color.Transparent;
            this.playerAttackInfoLabel.Font = new Font(
                "Microsoft Sans Serif", 
                9.5F, 
                FontStyle.Regular, 
                GraphicsUnit.Point, 
                204);
            this.playerAttackInfoLabel.ForeColor = Color.Cornsilk;
            this.playerAttackInfoLabel.Location = new Point(235, 301);
            this.playerAttackInfoLabel.Name = "playerAttackInfoLabel";
            this.playerAttackInfoLabel.Size = new Size(45, 16);
            this.playerAttackInfoLabel.TabIndex = 10;
            this.playerAttackInfoLabel.Text = "label1";
            this.playerAttackInfoLabel.Visible = false;

            // enemyAttackInfoLabel
            this.enemyAttackInfoLabel.AutoSize = true;
            this.enemyAttackInfoLabel.BackColor = Color.Transparent;
            this.enemyAttackInfoLabel.Font = new Font(
                "Microsoft Sans Serif", 
                9.5F, 
                FontStyle.Regular, 
                GraphicsUnit.Point, 
                204);
            this.enemyAttackInfoLabel.ForeColor = Color.Maroon;
            this.enemyAttackInfoLabel.Location = new Point(235, 223);
            this.enemyAttackInfoLabel.Name = "enemyAttackInfoLabel";
            this.enemyAttackInfoLabel.Size = new Size(45, 16);
            this.enemyAttackInfoLabel.TabIndex = 11;
            this.enemyAttackInfoLabel.Text = "label1";
            this.enemyAttackInfoLabel.Visible = false;

            // thirdSpellPictureBox
            this.thirdSpellPictureBox.Location = new Point(152, 494);
            this.thirdSpellPictureBox.Name = "thirdSpellPictureBox";
            this.thirdSpellPictureBox.Size = new Size(40, 40);
            this.thirdSpellPictureBox.TabIndex = 12;
            this.thirdSpellPictureBox.TabStop = false;
            this.thirdSpellPictureBox.Click += this.OnThirdMagicClick;

            // FirstLevelRoundTwoState
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoValidate = AutoValidate.Disable;
            this.BackgroundImage = Resources.LevelOneBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(793, 584);
            this.Controls.Add(this.thirdSpellPictureBox);
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
            this.Name = "FirstLevelRoundTwoState";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FirstLevelForm";
            this.Load += this.FirstLevelRoundThreeState_Load;
            ((ISupportInitialize)this.firstSpellPictureBox).EndInit();
            ((ISupportInitialize)this.secondSpellPictureox).EndInit();
            ((ISupportInitialize)this.playerPictureBox).EndInit();
            ((ISupportInitialize)this.enemyPictureBox).EndInit();
            ((ISupportInitialize)this.thirdSpellPictureBox).EndInit();
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
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "third" });
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }
    }
}