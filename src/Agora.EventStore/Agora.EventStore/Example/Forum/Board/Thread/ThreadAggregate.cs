using Agora.EventStore.Example.Forum.Board.Thread.Events;
using System;

namespace Agora.EventStore.Example.Forum.Board.Thread
{
    public class ThreadAggregate : Aggregate<ThreadState>
    {
        public ThreadAggregate()
        {
            Handles<AddPost>(OnAddPost);
            Handles<DeletePost>(OnDeletePost);
            Handles<EditPost>(OnEditPost);
        }

        private void OnEditPost(EditPost @event, ThreadState state)
        {
            state.
        }

        private void OnDeletePost(DeletePost @event, ThreadState state)
        {
            throw new NotImplementedException();
        }

        private void OnAddPost(AddPost @event, ThreadState state)
        {
            throw new NotImplementedException();
        }
    }
}
