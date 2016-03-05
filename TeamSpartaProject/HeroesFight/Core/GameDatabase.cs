namespace HeroesFight.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using HeroesFight.Enum;
    using HeroesFight.Interfaces;
    using HeroesFight.Utilities;

    public class GameDatabase : IDatabase
    {
        private string playerName;

        private IList<IEnemy> enemies;

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

        public IEnumerable<IEnemy> Enemies
        {
            get
            {
                return this.enemies;
            }
        }

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
            // ToDo: Initialize db.
        }
    }
}