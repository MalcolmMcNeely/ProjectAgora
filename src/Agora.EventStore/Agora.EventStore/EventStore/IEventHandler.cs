using System.Collections;
using System.Collections.Generic;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.EventStore
{
    public interface IEventHandler
    {
        IEnumerable<IEvent> CheckForEvents();
    }
}
