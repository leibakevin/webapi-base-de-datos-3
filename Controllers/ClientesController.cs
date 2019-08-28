using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiProductos.Model;


namespace ClientesController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ProductosContext context;
        
        public ClientesController(ProductosContext dbContext)
        {
            context = dbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Clientes>> Get()
        {
            return context.Clientes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Clientes> Get(int id)
        {
         return context.Clientes.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Clientes([FromBody] Clientes value)
        {
            context.Clientes.Add(value);
            context.SaveChanges();

            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clientes value)
        {
            var post = context.Clientes.Find(id);
            post.Nombre = value.Nombre;
            post.Apellido = value.Apellido;
            post.UserName = value.UserName;
            context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Clientes = context.Clientes.Find(id);
            context.Clientes.Remove(Clientes);
            context.SaveChanges();
        }
        
    }
        
}
