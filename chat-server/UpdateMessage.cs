using System;

namespace chat_server
{
    public class UpdateMessage
    {
        public string ConnectionId { get; set; }
        public int EventId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime DateTime { get; set; }
    }
}
