using Agora.EventStore.Example.Forum.Board.Thread.Events;
using Agora.EventStore.Example.Forum.Board.Thread.Exceptions;
using System;
using System.Linq;

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
            var post = state.Posts.FirstOrDefault(x => x.Id == @event.Id);

            if(post == null)
            {
                throw new PostNotFoundException("Post cannot be found");
            }

            post.Content = @event.Content;
        }

        private void OnDeletePost(DeletePost @event, ThreadState state)
        {
            var post = state.Posts.FirstOrDefault(x => x.Id == @event.Id);

            if(post == null)
            {
                throw new PostNotFoundException("Post cannot be found");
            }

            state.Posts.Remove(post);
        }

        private void OnAddPost(AddPost @event, ThreadState state)
        {
            state.Posts.Add(new Post
            {
                Author = @event.Author,
                Content = @event.Content,
                Id = Guid.NewGuid(),
            });
        }
    }
}
