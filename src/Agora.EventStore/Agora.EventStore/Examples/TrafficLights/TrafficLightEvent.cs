using Agora.EventStore.Eventing;

namespace Agora.EventStore.Examples.TrafficLights
{
    public class TrafficLightEvent : Event
    {
        public TrafficLightColour NewColour { get; set; }
    }
}
