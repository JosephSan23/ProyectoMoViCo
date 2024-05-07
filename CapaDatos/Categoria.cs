using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        //public ICollection<Producto> Productos { get; set; } // Colección de productos

        //public Categoria()
        //{
        //    Productos = new HashSet<Producto>();
        //}
    }
}
