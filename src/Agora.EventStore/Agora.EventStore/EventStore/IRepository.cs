using Agora.EventStore.Eventing;

namespace Agora.EventStore.EventStore
{
    public interface IRepository<T> where T : IAggregateState
    {
        T Load();

        void Save(T state);
    }
}
