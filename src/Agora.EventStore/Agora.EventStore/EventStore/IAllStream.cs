using Agora.EventStore.Eventing;

namespace Agora.EventStore.EventStore
{
    public interface IAllStream
    {
        void Update(string streamName, IEvent @event);
    }
}
