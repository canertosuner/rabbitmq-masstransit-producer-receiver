using System;
using MassTransit;
using RMQMessage;
using System.Threading.Tasks;

namespace RMQConsumer
{
    public class NewsletterMailMessageConsumer : IConsumer<NewsletterMailMessage>
    {
        public Task Consume(ConsumeContext<NewsletterMailMessage> context)
        {
            var message = context.Message;
            message.ConsumedTime = DateTime.Now;

            Console.WriteLine("Message consumed !\nSubject : " + message.NewsLetter.MailSubject + "\nConsumed at: " + message.ConsumedTime + "\nQueueId : " + message.QueueId);

            //todo send mail impr.

            return context.CompleteTask;
        }
    }
}
