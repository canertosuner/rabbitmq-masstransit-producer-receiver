using System.Collections.Generic;

namespace RMQMessage
{
    public class NewsletterMailMessage: BaseMessage
    {
        public List<string> AddressList { get; set; }
        public NewsletterModel NewsLetter { get; set; }
    }
}
