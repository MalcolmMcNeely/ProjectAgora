namespace Agora.EventStore.Example.Forum.Board.Thread.Events
{
    public class EditPost : PostEvent
    {
        public string Content { get; set; }
    }
}
