namespace HeroesFight.Entities.Commands
{
    #region

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.States;

    #endregion

    public class InitializeLevelThreeCommand : ICommand
    {
        public InitializeLevelThreeCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public static void Draw(IDatabase database, FirstLevelRoundThreeState state)
        {
            var graphics = state.CreateGraphics();

            DrawPlayerInfo(database, state, graphics);

            DrawEnemyInfo(database, state, graphics);
        }

        public void Execute(IDatabase database, State currentState)
        {
            var state = currentState as FirstLevelRoundThreeState;

            if (state == null)
            {
                throw new ArgumentNullException("State cannot be null!");
            }

            LoadImages(database, state);

            Draw(database, state);

            SetVisibility(state);
        }

        private static void DrawEnemyInfo(IDatabase database, FirstLevelRoundThreeState state, Graphics graphics)
        {
            var enemy = database.GetCurrentLevelEnemy();

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

            state.enemyHpLabel.Text = enemy.HealthPoints.ToString();
            state.enemyManaLabel.Text = enemy.ManaPoints.ToString();
        }

        private static void DrawPlayerInfo(IDatabase database, FirstLevelRoundThreeState state, Graphics graphics)
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
                $"{database.PlayerName}", 
                new Font(FontFamily.GenericMonospace, 18), 
                new SolidBrush(Color.Black), 
                60, 
                20);

            state.playerHpLabel.Text = database.Player.HealthPoints.ToString();
            state.playerManaLabel.Text = database.Player.ManaPoints.ToString();
        }

        private static void LoadImages(IDatabase database, FirstLevelRoundThreeState state)
        {
            state.enemyPictureBox.Image = (database.GetCurrentLevelEnemy() as GameObject).Sprite;
            state.enemyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            state.playerPictureBox.Image = (database.Player as GameObject).Sprite;
            state.playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            state.firstSpellPictureBox.Image = (database.GetCurrentMagicById(0) as GameObject).Sprite;
            state.firstSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            state.secondSpellPictureox.Image = (database.GetCurrentMagicById(1) as GameObject).Sprite;
            state.secondSpellPictureox.SizeMode = PictureBoxSizeMode.StretchImage;

            state.thirdSpellPictureBox.Image = (database.GetCurrentMagicById(2) as GameObject).Sprite;
            state.thirdSpellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            state.fourthMagicPictureBox.Image = (database.GetCurrentMagicById(3) as GameObject).Sprite;
            state.fourthMagicPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private static void SetVisibility(FirstLevelRoundThreeState state)
        {
            state.playerHpLabel.Visible = true;
            state.playerManaLabel.Visible = true;
            state.enemyHpLabel.Visible = true;
            state.enemyManaLabel.Visible = true;
            state.playerPictureBox.Visible = true;
            state.enemyPictureBox.Visible = true;

            state.firstSpellPictureBox.Visible = true;
            state.secondSpellPictureox.Visible = true;
            state.thirdSpellPictureBox.Visible = true;
            state.fourthMagicPictureBox.Visible = true;
        }
    }
}