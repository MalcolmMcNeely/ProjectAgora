using System;

namespace Agora.EventStore.Example.TrafficLights
{
    public class TrafficLightState : IAggregateState
    {
        public string Key { get; } = "TrafficLight";

        public TrafficLightColour CurrentColour;
    }
}
