using System;

namespace Agora.EventStore.Eventing
{
    public abstract class Event : IEvent
    {
        protected Event()
        {
            Id = Guid.NewGuid();
            RaisedAt = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime RaisedAt { get; set; }
    }
}
