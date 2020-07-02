using System.Collections.Generic;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.EventStore.InMemory
{
    public class InMemoryEventStore : IEventStore
    {
        public IAllStream AllStreamChangeTracker { get; set; }

        public InMemoryEventStore()
        {
            //AllStreamChangeTracker = In
        }

        public void CreateStream(string streamName)
        {
            throw new System.NotImplementedException();
        }

        public void AppendToStream(string streamName, IEvent eventData)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IEvent> ReadFromStream(string streamName)
        {
            throw new System.NotImplementedException();
        }
    }
}
