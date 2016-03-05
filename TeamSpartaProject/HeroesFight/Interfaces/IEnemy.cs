namespace HeroesFight.Interfaces
{
    using HeroesFight.Enum;

    public interface IEnemy : IHero
    {
        StateEnum WantedState { get; }
    }
}