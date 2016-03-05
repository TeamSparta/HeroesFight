namespace HeroesFight.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using HeroesFight.Enum;
    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.Utilities;

    public class GameDatabase : IDatabase
    {
        private string playerName;

        private readonly IList<IEnemy> enemies;

        private IList<IMagic> enemiesMagics;

        public GameDatabase(ICommandFactory commandFactory, IHeroFactory heroFactory, IMagicFactory magicFactory)
        {
            this.CommandFactory = commandFactory;
            this.HeroFactory = heroFactory;
            this.MagicFactory = magicFactory;
            this.enemies = new List<IEnemy>();
            this.enemiesMagics = new List<IMagic>();
            this.WarriorsMagicsByLevel = new Dictionary<StateEnum, IList<IMagic>>();
            this.ArchersMagicsByLevel = new Dictionary<StateEnum, IList<IMagic>>();
            this.CurrentPlayerProgress = StateEnum.FirstLevelRoundOneState;
            this.Initialize();
        }

        public IPlayer Player { get; private set; }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            private set
            {
                Regex nameRegex = new Regex(@"([\w]+){3,20}$");

                if (nameRegex.IsMatch(value))
                {
                    this.playerName = value;
                }
                else
                {
                    throw new ArgumentException("Name should be between 3 and 20 characters long and should consist only letters and digits.");
                }
            }
        }
        
        // Probably useless.
        public IEnumerable<IEnemy> Enemies
        {
            get
            {
                return this.enemies;
            }
        }

        // Probably useless.
        public IEnumerable<IMagic> EnemyMagics
        {
            get
            {
                return this.enemiesMagics;
            }
        }

        public IMagicFactory MagicFactory { get; }

        public ICommandFactory CommandFactory { get; }

        public IHeroFactory HeroFactory { get; }

        public IDictionary<StateEnum, IList<IMagic>> WarriorsMagicsByLevel { get; }

        public IDictionary<StateEnum, IList<IMagic>> ArchersMagicsByLevel { get; }

        public StateEnum CurrentPlayerProgress { get; private set; }

        public IMagic GetEnemyMagic(string magicName)
        {
            if (string.IsNullOrEmpty(magicName))
            {
                throw new ArgumentException("Magic name cannot be empty or null!");
            }

            IMagic magic = this.enemiesMagics.FirstOrDefault(m => m.Name == magicName);

            if (magic == null)
            {
                throw new MagicNotFoundException($"Magic with name {magicName} was not found!");
            }

            return magic;

        }

        public void Update()
        {
            this.CurrentPlayerProgress++;
        }

        public void AddPlayer(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Cannot add null player!");
            }

            this.Player = player;
        }

        public void AddPlayerName(string inputName)
        {
            this.PlayerName = inputName;
        }

        private void Initialize()
        {
            this.InitializeFirstBoss();

            this.InitializeSecondBoss();

            this.InitializeThirdBoss();
        }

        private void InitializeThirdBoss()
        {
            IEnemy bloodlineMagician = this.HeroFactory.CreateHero(ClassHeroEnum.Enemy, "BloodLineMagician") as IEnemy;

            IMagic bloodDrain = this.MagicFactory.CreateMagic("BloodDrain");
            bloodlineMagician.AddMagic(bloodDrain);
            IMagic bloodPool = this.MagicFactory.CreateMagic("BloodPool");
            bloodlineMagician.AddMagic(bloodPool);
            IMagic magicArc = this.MagicFactory.CreateMagic("MagicArc");
            bloodlineMagician.AddMagic(magicArc);
            IMagic bloodFire = this.MagicFactory.CreateMagic("BloodFire");
            bloodlineMagician.AddMagic(bloodFire);

            this.enemies.Add(bloodlineMagician);
        }

        private void InitializeSecondBoss()
        {
            IEnemy fireArcher = this.HeroFactory.CreateHero(ClassHeroEnum.Enemy, "FireArcher") as IEnemy;
            IMagic fireArrow = this.MagicFactory.CreateMagic("FireArrow");
            fireArcher.AddMagic(fireArrow);
            IMagic bomb = this.MagicFactory.CreateMagic("Bomb");
            fireArcher.AddMagic(bomb);
            IMagic steadyShot = this.MagicFactory.CreateMagic("SteadyShot");
            fireArcher.AddMagic(steadyShot);

            this.enemies.Add(fireArcher);
        }

        private void InitializeFirstBoss()
        {
            IEnemy unholyWarrior = this.HeroFactory.CreateHero(ClassHeroEnum.Enemy, "UnholyWarrior") as IEnemy;

            IMagic swordThrowMagic = this.MagicFactory.CreateMagic("SwordThrow");
            unholyWarrior.AddMagic(swordThrowMagic);
            IMagic furiousRush = this.MagicFactory.CreateMagic("FuriousRush");
            unholyWarrior.AddMagic(furiousRush);

            this.enemies.Add(unholyWarrior);
        }
    }
}