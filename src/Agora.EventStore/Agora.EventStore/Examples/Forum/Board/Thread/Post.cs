using System;

namespace Agora.EventStore.Examples.Forum.Board.Thread
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}
