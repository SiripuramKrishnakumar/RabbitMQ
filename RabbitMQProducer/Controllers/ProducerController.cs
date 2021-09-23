using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;

namespace RabbitMQProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {

        private readonly IBusControl _bus;
        public ProducerController(IBusControl bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> GenerateMessage([FromBody]Message message)
        {
            Uri uri = new Uri("rabbitmq://localhost/MessageQueue");
            var endpoint = await _bus.GetSendEndpoint(uri);
            await endpoint.Send(message);
            return Ok("Message Sent Successfully.");
        }
    }
}
