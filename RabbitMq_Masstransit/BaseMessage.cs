using System;

namespace RMQMessage
{
    public abstract class BaseMessage
    {
        public DateTime PublishedTime { get; set; }
        public DateTime ConsumedTime { get; set; }
        public Guid QueueId { get; set; }
    }
}
