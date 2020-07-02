using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.Processing
{
    public class EventProcessor
    {
        readonly ConcurrentQueue<IEvent> _postedEvents = new ConcurrentQueue<IEvent>();

        List<IAggregate> _aggregates;

        public EventProcessor()
        {
            _aggregates = GetType().Assembly.GetTypes()
                .Where(x => typeof(IAggregate).IsAssignableFrom(x))
                .Select(x => (IAggregate)Activator.CreateInstance(x))
                .ToList();
        }

        public void PostMessageAsync(IEvent @event)
        {
            _postedEvents.Enqueue(@event);
        }

        public void ProcessPendingEvents()
        {
            while (_postedEvents.TryDequeue(out var @event))
            {
                // Fire off events to relevant aggregates
            }
        }
    }
}
