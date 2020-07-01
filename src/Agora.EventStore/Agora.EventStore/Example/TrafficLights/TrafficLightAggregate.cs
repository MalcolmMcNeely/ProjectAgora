namespace Agora.EventStore.Example.TrafficLights
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