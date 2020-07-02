using Agora.EventStore.Eventing;

namespace Agora.EventStore.Examples.TrafficLights
{
    public class TrafficLightAggregate : Aggregate<TrafficLightState>
    {
        public TrafficLightAggregate()
        {
            Handles<TrafficLightEvent>(OnTrafficLightEvent);
        }

        private void OnTrafficLightEvent(TrafficLightEvent @event, TrafficLightState state)
        {
            state.CurrentColour = @event.NewColour;
        }
    }
}