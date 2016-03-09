namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enums;

    #endregion

    public interface IEnemy : IHero
    {
        StateEnum WantedState { get; }
    }
}