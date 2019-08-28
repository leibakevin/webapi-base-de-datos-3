using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiProductos.Model
{
     public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options)
            : base(options)
        { }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
    }
    
        
        public class Productos
    {
        public int Precio { get; set; }
        public string Titulo { get; set; }
//        public DateTime ReleaseDate { get; set; }
        public string Descripcion { get; set; }  

        public Categoria Categoria { get; set; }

         public List<Productos> Posts { get; set; }

         public int Id { get; set; }
    }

public class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
//        public DateTime ReleaseDate { get; set; }
        public string UserName { get; set; }  

        public int mail { get; set; }
        
        public int Id { get; set; }
    }
    
}