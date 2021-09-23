using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQConsumer
{
    public static class MessageData
    {
        static MessageData()
        {
            Messages = new List<Message>();
        }
        public static List<Message> Messages { get; set; }
    }
    public class Message
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
