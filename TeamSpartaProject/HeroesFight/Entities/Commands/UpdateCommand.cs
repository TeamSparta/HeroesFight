namespace HeroesFight.Entities.Commands
{
    #region

    using System.Drawing;

    using HeroesFight.Interfaces;
    using HeroesFight.States;
    using HeroesFight.Utilities;

    #endregion

    public class UpdateCommand : ICommand
    {
        public UpdateCommand(string commandName, object[] commandParameters)
        {
            this.CommandName = commandName;
            this.CommandParameters = commandParameters;
        }

        public string CommandName { get; }

        public object[] CommandParameters { get; }

        public void Execute(IDatabase database, State currentState)
        {
            if (!database.Player.IsAlive)
            {
            }

            var state = currentState as FirstLevelRoundOneState;

            if (state == null)
            {
                throw new InvalidStateException();
            }

            this.Draw(database, state);
        }

        private void Draw(IDatabase database, FirstLevelRoundOneState state)
        {
            var graphics = state.CreateGraphics();

            this.DrawPlayerInfo(database, state, graphics);

            this.DrawEnemyInfo(database, state, graphics);
        }

        private void DrawEnemyInfo(IDatabase database, FirstLevelRoundOneState state, Graphics graphics)
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

            // ToDo: Fix the bug with bars.
            state.enemyHpLabel.Text = enemy.HealthPoints.ToString();
            state.enemyManaLabel.Text = enemy.ManaPoints.ToString();
        }

        private void DrawPlayerInfo(IDatabase database, FirstLevelRoundOneState state, Graphics graphics)
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
    }
}