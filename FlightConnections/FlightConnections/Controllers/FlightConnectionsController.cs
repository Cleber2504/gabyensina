using FlightConnections.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FlightConnections.Controllers
{
    public class FlightConnectionsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Post(string nome) { return Ok();}

        [HttpGet("{origin}/{destiny}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Get(){ return Ok(); }

        [HttpGet("{Id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Get(int id) { 
            FlightRoutes routes = new FlightRoutes();
            return Ok();
        }

        [HttpDelete("Id")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Delete(int id) { return Ok(); }

        [HttpPut("Id")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> Put(int id) { return Ok(); }




    }
}
