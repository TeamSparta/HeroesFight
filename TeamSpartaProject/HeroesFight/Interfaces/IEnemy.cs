namespace HeroesFight.Interfaces
{
    #region

    using HeroesFight.Enum;

    #endregion

    public interface IEnemy : IHero
    {
        StateEnum WantedState { get; }
    }
}