namespace Agora.EventStore.Example.TrafficLights
{
    public class TrafficLightEvent : Event
    {
        public TrafficLightColour NewColour { get; set; }
    }
}
