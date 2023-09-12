using Microsoft.AspNetCore.Mvc;
using MiPrimeraAplicacionWebApiConControladores.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiPrimeraAplicacionWebApiConControladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        static List<Client> clients = new List<Client>();

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clients;
        }


        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            return client;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            clients.Add(client);
            return Ok();
        }
    }
}
