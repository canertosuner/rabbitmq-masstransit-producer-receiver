using System;
using MassTransit;

namespace RMQConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri("rabbitmq://localhost/"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ReceiveEndpoint(host, "DailyNewsletterMail", e =>
                e.Consumer<NewsletterMailMessageConsumer>());
            });

            busControl.Start();
            Console.WriteLine("Started consuming.");
            Console.ReadLine();
        }
    }
}
