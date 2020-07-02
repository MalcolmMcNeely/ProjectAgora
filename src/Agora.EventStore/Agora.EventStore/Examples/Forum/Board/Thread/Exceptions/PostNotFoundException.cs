using System;

namespace Agora.EventStore.Examples.Forum.Board.Thread.Exceptions
{
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException(string message) : base(message)
        {

        }
    }
}
