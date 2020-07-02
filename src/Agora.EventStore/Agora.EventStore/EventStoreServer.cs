using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Agora.EventStore.Eventing;
using Agora.EventStore.Processing;

namespace Agora.EventStore
{
    public class EventStoreServer
    {
        static EventStoreServer _server;
        public static EventStoreServer Server => _server ?? (_server = new EventStoreServer());

        readonly CancellationTokenSource _cancellationTokenSource;
        readonly EventProcessor _eventProcessor = new EventProcessor();
        CancellationToken _cancellationToken;
        Timer _messageProcessingTimer;

        public EventStoreServerConfiguration Configuration { get; set; } = new EventStoreServerConfiguration();
        public bool IsRunning { get; set; }

        EventStoreServer()
        {
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            IsRunning = true;
            _cancellationToken = _cancellationTokenSource.Token;

            StartProcessingMessages();
        }

        public void Stop()
        {
            IsRunning = false;
            _cancellationTokenSource.Cancel();

            StopProcessingMessages();
        }

        public void PostEvent(IEvent @event)
        {
            _eventProcessor.PostMessageAsync(@event);
        }

        void StartProcessingMessages()
        {
            _messageProcessingTimer = new Timer(ProcessMessages, null, 0, Configuration.ProcessingInterval);
        }

        void StopProcessingMessages()
        {
            _messageProcessingTimer.Dispose();
        }

        void ProcessMessages(object state)
        {
            Task.Factory.StartNew(() =>
            {
                _eventProcessor.ProcessPendingEvents();
            }, _cancellationToken);
        }
    }
}
