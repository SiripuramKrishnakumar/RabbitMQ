using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok(MessageData.Messages);
        }
            
    }
}
