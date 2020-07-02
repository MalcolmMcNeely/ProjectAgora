using System;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.Examples.Forum.Board.Thread.Events
{
    public class PostEvent : Event
    {
        public Guid Thread { get; set; }
        public string Author { get; set; }
    }
}
