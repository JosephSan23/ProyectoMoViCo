using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        //public ICollection<Producto> Productos { get; set; } // Colección de productos

        //public Marca()
        //{
        //    Productos = new HashSet<Producto>();
        //}

    }
}
