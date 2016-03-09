namespace HeroesFight.Core
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using HeroesFight.Enums;
    using HeroesFight.GameObjects.Heroes;
    using HeroesFight.Interfaces;

    #endregion

    public class GameDatabase : IDatabase
    {
        private readonly IList<IEnemy> enemies;

        private readonly IDictionary<StateEnum, IList<IMagic>> warriorsMagicsByLevel;

        private readonly IDictionary<StateEnum, IList<IMagic>> archersMagicsByLevel;

        private int startingHealth;

        private int startingMana;

        private string playerName;

        public GameDatabase(ICommandFactory commandFactory, IHeroFactory heroFactory, IMagicFactory magicFactory)
        {
            this.CommandFactory = commandFactory;
            this.HeroFactory = heroFactory;
            this.MagicFactory = magicFactory;
            this.CurrentState = StateEnum.PickCharacterState;
            this.enemies = new List<IEnemy>();
            this.warriorsMagicsByLevel = new Dictionary<StateEnum, IList<IMagic>>();
            this.archersMagicsByLevel = new Dictionary<StateEnum, IList<IMagic>>();
            this.Initialize();
        }

        public ICommandFactory CommandFactory { get; }

        public IHeroFactory HeroFactory { get; }

        public IMagicFactory MagicFactory { get; }

        public IPlayer Player { get; private set; }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            private set
            {
                Regex nameRegex = new Regex(@"^\w{3,20}$");

                if (nameRegex.IsMatch(value))
                {
                    this.playerName = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Name should be between 3 and 20 characters long and should consist only of letters and digits.");
                }
            }
        }

        public StateEnum CurrentState { get; private set; }

        public void AddPlayer(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Cannot add null player!");
            }

            this.startingHealth = player.HealthPoints;
            this.startingMana = player.ManaPoints;
            this.Player = player;
            this.InitializePlayerMagics();
        }

        public void AddPlayerName(string inputName)
        {
            this.PlayerName = inputName;
        }

        public IMagic GetPlayerMagicById(int id)
        {
            if (id >= this.Player.Magics.Count() || id < 0)
            {
                throw new ArgumentOutOfRangeException("Index is either too big or too low!");
            }

            int count = 0;
            IMagic resultMagic = null;

            foreach (IMagic magic in this.Player.Magics)
            {
                if (count == id)
                {
                    resultMagic = magic;
                    break;
                }

                count++;
            }

            return resultMagic;
        }

        public void Initialize()
        {
            this.InitializeFirstBoss();

            this.InitializeSecondBoss();

            this.InitializeThirdBoss();
        }

        public void Update()
        {
            this.CurrentState++;
            this.UpdatePlayerMagics();
            this.Player.HealthPoints = this.startingHealth;
            this.Player.ManaPoints = this.startingMana;
        }

        public IEnemy GetCurrentLevelEnemy()
        {
            IEnemy currentEnemy = this.enemies.FirstOrDefault(e => e.WantedState == this.CurrentState);
            if (currentEnemy == null)
            {
                throw new ArgumentNullException("Enemy cannot be null!");
            }

            return currentEnemy;
        }

        private void InitializeArcherMagics()
        {
            IMagic counterShot = this.MagicFactory.CreateMagic("CounterShot");
            this.archersMagicsByLevel.Add(StateEnum.FirstLevelRoundOneState, new List<IMagic> { counterShot });
            IMagic threeShot = this.MagicFactory.CreateMagic("ThreeShot");
            this.archersMagicsByLevel[StateEnum.FirstLevelRoundOneState].Add(threeShot);

            IMagic critShot = this.MagicFactory.CreateMagic("CritShot");
            this.archersMagicsByLevel.Add(StateEnum.FirstLevelRoundTwoState, new List<IMagic> { critShot });

            IMagic mortalShot = this.MagicFactory.CreateMagic("MortalShot");
            this.archersMagicsByLevel.Add(StateEnum.FirstLevelRoundThreeState, new List<IMagic> { mortalShot });
        }

        private void InitializeWarriorMagics()
        {
            IMagic fistAttack = this.MagicFactory.CreateMagic("FistAttack");
            this.warriorsMagicsByLevel.Add(StateEnum.FirstLevelRoundOneState, new List<IMagic> { fistAttack });
            IMagic swordAttack = this.MagicFactory.CreateMagic("SwordAttack");
            this.warriorsMagicsByLevel[StateEnum.FirstLevelRoundOneState].Add(swordAttack);

            IMagic poisonStrike = this.MagicFactory.CreateMagic("PoisonStrike");
            this.warriorsMagicsByLevel.Add(StateEnum.FirstLevelRoundTwoState, new List<IMagic> { poisonStrike });

            IMagic lightningStrike = this.MagicFactory.CreateMagic("LightningStrike");
            this.warriorsMagicsByLevel.Add(StateEnum.FirstLevelRoundThreeState, new List<IMagic> { lightningStrike });
        }

        private void InitializePlayerMagics()
        {
            if (this.Player is Archer)
            {
                this.InitializeArcherMagics();
                List<IMagic> playerMagics = this.archersMagicsByLevel[StateEnum.FirstLevelRoundOneState].ToList();

                foreach (IMagic magic in playerMagics)
                {
                    this.Player.AddMagic(magic);
                }
            }
            else
            {
                this.InitializeWarriorMagics();
                List<IMagic> playerMagics = this.warriorsMagicsByLevel[StateEnum.FirstLevelRoundOneState].ToList();

                foreach (IMagic magic in playerMagics)
                {
                    this.Player.AddMagic(magic);
                }
            }
        }

        private void InitializeFirstBoss()
        {
            IEnemy unholyWarrior = this.HeroFactory.CreateHero(HeroClass.Enemy, "UnholyWarrior") as IEnemy;

            IMagic swordThrowMagic = this.MagicFactory.CreateMagic("SwordThrow");
            unholyWarrior.AddMagic(swordThrowMagic);
            IMagic furiousRush = this.MagicFactory.CreateMagic("FuriousRush");
            unholyWarrior.AddMagic(furiousRush);

            this.enemies.Add(unholyWarrior);
        }

        private void InitializeSecondBoss()
        {
            IEnemy fireArcher = this.HeroFactory.CreateHero(HeroClass.Enemy, "FireArcher") as IEnemy;
            IMagic fireArrow = this.MagicFactory.CreateMagic("FireArrow");
            fireArcher.AddMagic(fireArrow);
            IMagic bomb = this.MagicFactory.CreateMagic("Bomb");
            fireArcher.AddMagic(bomb);
            IMagic steadyShot = this.MagicFactory.CreateMagic("SteadyShot");
            fireArcher.AddMagic(steadyShot);

            this.enemies.Add(fireArcher);
        }

        private void InitializeThirdBoss()
        {
            IEnemy bloodlineMagician = this.HeroFactory.CreateHero(HeroClass.Enemy, "BloodLineMagician") as IEnemy;

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

        private void UpdatePlayerMagics()
        {
            if (this.Player is Archer)
            {
                List<IMagic> nextMagics = this.archersMagicsByLevel[this.CurrentState].ToList();
                foreach (IMagic magic in nextMagics)
                {
                    this.Player.AddMagic(magic);
                }
            }
            else
            {
                List<IMagic> nextMagics = this.warriorsMagicsByLevel[this.CurrentState].ToList();
                foreach (IMagic magic in nextMagics)
                {
                    this.Player.AddMagic(magic);
                }
            }
        }
    }
}