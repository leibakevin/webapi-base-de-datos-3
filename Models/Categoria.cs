using System.ComponentModel.DataAnnotations;

namespace ApiProductos.Model
{
    public class Categoria
    {   
       
        public string Titulo { get; set; }

        [Key]
        public int Id { get; set; }
    }
}