namespace HeroesFight.Interfaces
{
    using System.Collections.Generic;

    using HeroesFight.Enum;

    public interface IPlayerDatabase
    {
        /// <summary>
        /// The name user have inserted.
        /// </summary>
        string PlayerName { get; }

        /// <summary>
        /// The player current hero state.
        /// </summary>
        IPlayer Player { get; }

        /// <summary>
        /// Gets Warrior class magics by level completed.
        /// </summary>
        IDictionary<StateEnum, IList<IMagic>> WarriorsMagicsByLevel { get; }

        /// <summary>
        /// Gets Archer class magics by level completed.
        /// </summary>
        IDictionary<StateEnum, IList<IMagic>> ArchersMagicsByLevel { get; }

        /// <summary>
        /// Gets the current progress of the player.
        /// </summary>
        StateEnum CurrentPlayerProgress { get; }

        /// <summary>
        /// Method used for initializing the player after the all the information wass passed by the user. 
        /// </summary>
        /// <param name="player"></param>
        void AddPlayer(IPlayer player);

        /// <summary>
        /// Adds a username which has to be saved.
        /// </summary>
        /// <param name="playerName"></param>
        void AddPlayerName(string playerName);
    }
}