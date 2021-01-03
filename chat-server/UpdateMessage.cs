using System;

namespace chat_server
{
    public enum EventType
    {
        Lock,
        Release
    }

    public class UpdateMessage
    {
        public string ConnectionId { get; set; }
        public int EventId { get; set; }
        public EventType EventType { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime DateTime { get; set; }
    }
}
