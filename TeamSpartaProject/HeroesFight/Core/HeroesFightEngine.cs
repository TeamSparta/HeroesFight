namespace HeroesFight.Core
{
    using System.Windows.Forms;

    using HeroesFight.Interfaces;

    public class HeroesFightEngine : IRunnable
    {
        public HeroesFightEngine(IDataBase gameData)
        {
            this.DataBase = gameData;
        }

        public IDataBase DataBase { get; private set; }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeroesFightStartForm());

            // Application.Run(new State());
        }
    }
}
