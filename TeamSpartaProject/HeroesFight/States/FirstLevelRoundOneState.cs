namespace HeroesFight.States
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
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

            this.firstSpellPictureBox.Image = (database.GetCurrentMagicById(0) as GameObject).Sprite;
            this.firstSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.secondSpellPictureox.Image = (database.GetCurrentMagicById(1) as GameObject).Sprite;
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
            this.CommandDispatcher.Database.Initialize();
        }

        private void OnBattleButtonClick(object sender, EventArgs e)
        {
            this.Btn_Attack.Visible = false;

            this.CommandDispatcher.ProcessCommand("Initialize", null);
        }

        private void OnFirstMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "firstMagic" });
            this.CommandDispatcher.ProcessCommand("Update", null);

            if (this.CommandDispatcher.Database.CurrentEnemy.IsAlive)
            {
                this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                this.CommandDispatcher.ProcessCommand("Update", null);
            }
        }

        private void OnSecondMagicClick(object sender, EventArgs e)
        {
            this.CommandDispatcher.ProcessCommand("Attack", new object[] { "secondMagic" });

            // Imagine if you try to click on magic and you have no mana/health to perform it. It will be counted as a turn and the enemy will attack you. 
            // And basically you will have not be done anything(action) so I believe is not appropriate that way.
            if (!this.playerAttackInfoLabel.Text.StartsWith("Not enough"))
            {
                this.CommandDispatcher.ProcessCommand("Update", null);
                if (this.CommandDispatcher.Database.CurrentEnemy.IsAlive)
                {
                    this.CommandDispatcher.ProcessCommand("EnemyAttack", null);
                    this.CommandDispatcher.ProcessCommand("Update", null);
                }
            }
        }
    }
}