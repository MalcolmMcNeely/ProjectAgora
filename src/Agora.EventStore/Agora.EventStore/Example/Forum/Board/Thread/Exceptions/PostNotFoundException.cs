using System;

namespace Agora.EventStore.Example.Forum.Board.Thread.Exceptions
{
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException(string message) : base(message)
        {

        }
    }
}
