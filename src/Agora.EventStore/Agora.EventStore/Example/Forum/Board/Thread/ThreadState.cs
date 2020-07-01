using System.Collections.Generic;

namespace Agora.EventStore.Example.Forum.Board.Thread
{
    public class ThreadState : IAggregateState
    {
        public string Key => throw new System.NotImplementedException();

        public string ThreadTopic { get; set; }
        public List<string> Messages { get; set; }
    }
}
