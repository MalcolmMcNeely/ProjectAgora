namespace Agora.EventStore.Example.Forum.Board.Thread.Events
{
    public class AddPost : PostEvent
    {
        public string Content { get; set; }
    }
}
