using System;

namespace Agora.EventStore
{
    public interface IEvent
    {
        public Guid Id { get; set; }
        public DateTime RaisedAt { get; set; }
    }
}
