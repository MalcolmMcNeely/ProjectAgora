namespace Agora.EventStore.Examples.Forum.Board.Thread.Events
{
    public class AddPost : PostEvent
    {
        public string Content { get; set; }
    }
}
