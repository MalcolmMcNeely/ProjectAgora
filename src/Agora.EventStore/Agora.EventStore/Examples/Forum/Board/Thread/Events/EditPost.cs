namespace Agora.EventStore.Examples.Forum.Board.Thread.Events
{
    public class EditPost : PostEvent
    {
        public string Content { get; set; }
    }
}
