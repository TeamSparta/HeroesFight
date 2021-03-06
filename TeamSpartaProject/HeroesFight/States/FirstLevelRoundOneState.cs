﻿namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;

    #endregion

    public partial class FirstLevelRoundOneState : State
    {
        public FirstLevelRoundOneState(ICommandDispatcher commandDispatcher)
        {
            this.CommandDispatcher = commandDispatcher;
            this.InitializeComponent();
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

        private void SetVisibility()
        {
            this.playerHpLabel.Visible = true;
            this.playerManaLabel.Visible = true;
            this.enemyHpLabel.Visible = true;
            this.enemyManaLabel.Visible = true;
            this.playerPictureBox.Visible = true;
            this.enemyPictureBox.Visible = true;
            this.firstSpellPictureBox.Visible = true;
            this.secondSpellPictureox.Visible = true;
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

            this.secondSpellPictureox.Image = (database.GetPlayerMagicById(1) as GameObject).Sprite;
            this.secondSpellPictureox.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void FirstLevelForm_Load(object sender, EventArgs e)
        {
            this.playerPictureBox.Visible = false;
            this.enemyPictureBox.Visible = false;
            this.firstSpellPictureBox.Visible = false;
            this.secondSpellPictureox.Visible = false;
        }

        private void UpdateMagicsGameInfo()
        {
            IMagic firstMagic = this.CommandDispatcher.Database.GetPlayerMagicById(0);
            this.firstMagicTooltip.SetToolTip(this.firstSpellPictureBox, (firstMagic as Magic).ToString());

            IMagic secondMagic = this.CommandDispatcher.Database.GetPlayerMagicById(1);
            this.secondMagicTooltip.SetToolTip(this.secondSpellPictureox, (secondMagic as Magic).ToString());
        }

        private void UpdateHeroesGameInfo()
        {
            IEnemy enemy = this.CommandDispatcher.Database.GetCurrentLevelEnemy();
            string enemyInfo = "Fearsome warrior part of the army of the undead and unholy horde.\n"
                               + (enemy as Hero).ToString();
            this.enemyTooltip.SetToolTip(this.enemyPictureBox, enemyInfo);

            IPlayer player = this.CommandDispatcher.Database.Player;
            this.playerTooltip.SetToolTip(this.playerPictureBox, (player as Hero).ToString());
        }

        private void OnBattleButtonClick(object sender, EventArgs e)
        {
            this.Btn_Attack.Visible = false;

            this.CommandDispatcher.ProcessCommand("Initialize", null);
        }

        private void OnFirstMagicClick(object sender, EventArgs e)
        {
            var prevProgress = this.CommandDispatcher.Database.CurrentState;
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "firstMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);

            if (prevProgress == this.CommandDispatcher.Database.CurrentState)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
            else
            {
                StateManager.CurrentState.Draw();
            }
        }

        private void OnSecondMagicClick(object sender, EventArgs e)
        {
            var prevProgress = this.CommandDispatcher.Database.CurrentState;

            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });

            // ToDo: Check this case.
            // Imagine if you try to click on magic and you have no mana/health to perform it. It will be counted as a turn and the enemy will attack you. 
            // And basically you will have not be done anything(action) so I believe is not appropriate that way.
            
            this.CommandDispatcher.ProcessCommand("Update", null);
            if (prevProgress == this.CommandDispatcher.Database.CurrentState)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }

        }
    }
}