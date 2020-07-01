using System.Collections.Generic;

namespace Agora.EventStore.Example.Forum.Board.Thread
{
    public class ThreadState : IAggregateState
    {
        public string Key => "Thread";

        public string ThreadTopic { get; set; }
        public List<Post> Posts { get; set; }
    }
}
