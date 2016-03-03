namespace HeroesFight.Interfaces
{
    public interface ICommand
    {
        void Execute(IDataBase database, State currentState);
    }
}
