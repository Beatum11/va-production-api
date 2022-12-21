using Microsoft.AspNetCore.Mvc;
using VA_Prod_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VA_Prod_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        #region Basic set-up
        private readonly Context Context;

        public ClientsController(Context context)
        {
            Context = context;
        }
        #endregion

        // GET: api/<ClientsController>
        [HttpGet]
        public List<Client> Get()
        {
            return Context.Clients.ToList();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = Context.Clients.Where(c => c.Id == id).FirstOrDefault();
            return client;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post(Client client)
        {
            Context.Clients.Add(client);
            Context.SaveChanges();
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Client client)
        {
            var neededClient = Context.Clients.Where(c => c.Id == id).FirstOrDefault();

            Context.Clients.Remove(neededClient);
            Context.Clients.Add(client);
            Context.SaveChanges();
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var client = Context.Clients.Where(c => c.Id == id).ToList().FirstOrDefault();
            Context.Clients.Remove(client);
            Context.SaveChanges();
        }
    }
}
