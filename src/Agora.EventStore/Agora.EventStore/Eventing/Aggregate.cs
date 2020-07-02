using System;
using System.Collections.Generic;

namespace Agora.EventStore.Eventing
{
    public class Aggregate<TAggregateState> : IAggregate where TAggregateState : IAggregateState, new()
    {
        public delegate void Handler<in TEvent>(TEvent @event, TAggregateState state) where TEvent : IEvent;

        readonly Dictionary<Type, Action<string, IEvent, IAggregateState>> _handlers = new Dictionary<Type, Action<string, IEvent, IAggregateState>>();

        public Aggregate()
        {
            // Need a Repo?
        }

        public void Handles<TEvent>(Handler<TEvent> handler) where TEvent : IEvent
        {
            _handlers.Add(typeof(IEvent), (key, Event, state) => handler((TEvent)Event, (TAggregateState)state));
        }
    }
}
