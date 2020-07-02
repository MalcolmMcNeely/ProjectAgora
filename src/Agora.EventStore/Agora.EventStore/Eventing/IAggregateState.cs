namespace Agora.EventStore.Eventing
{
    public interface IAggregateState
    {
        string Key { get; }
    }
}
