using Agora.EventStore.Eventing;

namespace Agora.EventStore.Examples.TrafficLights
{
    public class TrafficLightState : IAggregateState
    {
        public string Key { get; } = "TrafficLight";

        public TrafficLightColour CurrentColour;
    }
}
