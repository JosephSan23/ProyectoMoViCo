using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Carrito
    {
        public int CarritoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente oCliente { get; set; }
        public int oProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
