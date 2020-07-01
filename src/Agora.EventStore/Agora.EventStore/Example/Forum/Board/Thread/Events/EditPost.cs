namespace Agora.EventStore.Example.Forum.Board.Thread.Events
{
    public class EditPost : PostEvent
    {
        string Content { get; set; }
    }
}
