using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiProductos.Model;


namespace CategoriaController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ProductosContext context;
        
        public CategoriaController(ProductosContext dbContext)
        {
            context = dbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return context.Categorias.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
         return context.Categorias.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Categoria([FromBody] Categoria value)
        {
            context.Categorias.Add(value);
            context.SaveChanges();

            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Categoria value)
        {
            var categoria = context.Categorias.Find(id);
            categoria.Titulo = value.Titulo;
            
            context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Categoria = context.Categorias.Find(id);
            context.Categorias.Remove(Categoria);
            context.SaveChanges();
        }
        
    }
        
}
