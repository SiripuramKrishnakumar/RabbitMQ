using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
namespace RabbitMQConsumer
{
    public class MessageConsumer : IConsumer<Message>
    {
        public async Task Consume(ConsumeContext<Message> context)
        {
            await Task.Run(() =>
            {
                MessageData.Messages.Add(context.Message);
            });
        }
    }
}
