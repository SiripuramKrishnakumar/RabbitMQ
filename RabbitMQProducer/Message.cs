using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQProducer
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
