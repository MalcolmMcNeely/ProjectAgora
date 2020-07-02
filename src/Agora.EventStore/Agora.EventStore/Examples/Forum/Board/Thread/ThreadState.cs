using System.Collections.Generic;
using Agora.EventStore.Eventing;

namespace Agora.EventStore.Examples.Forum.Board.Thread
{
    public class ThreadState : IAggregateState
    {
        public string Key => "Thread";

        public string ThreadTopic { get; set; }
        public List<Post> Posts { get; set; }
    }
}
