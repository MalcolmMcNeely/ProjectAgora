namespace Agora.EventStore.Eventing
{
    public interface IAggregate
    {
        AggregateMapper GetMapper();
    }
}
