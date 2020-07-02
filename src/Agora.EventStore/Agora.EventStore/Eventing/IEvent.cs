using System;

namespace Agora.EventStore.Eventing
{
    public interface IEvent
    {
        Guid Id { get; set; }
        DateTime RaisedAt { get; set; }
    }
}
