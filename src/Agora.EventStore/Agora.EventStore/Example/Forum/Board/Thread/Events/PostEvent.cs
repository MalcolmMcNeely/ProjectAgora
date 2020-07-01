using System;

namespace Agora.EventStore.Example.Forum.Board.Thread.Events
{
    public class PostEvent : Event
    {
        public Guid Thread { get; set; }
        public string Author { get; set; }
    }
}
