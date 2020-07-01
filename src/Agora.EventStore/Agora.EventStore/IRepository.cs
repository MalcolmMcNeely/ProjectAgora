namespace Agora.EventStore
{
    public interface IRepository<T> where T : IAggregateState
    {
        T Load();

        void Save();
    }
}
