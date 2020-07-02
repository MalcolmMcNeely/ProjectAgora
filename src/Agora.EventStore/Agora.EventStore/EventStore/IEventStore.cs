using System.Collections.Generic;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.EventStore
{
    public interface IEventStore
    {
        void CreateStream(string streamName);
        void AppendToStream(string streamName, IEvent eventData);
        IEnumerable<IEvent> ReadFromStream(string streamName);
    }
}
