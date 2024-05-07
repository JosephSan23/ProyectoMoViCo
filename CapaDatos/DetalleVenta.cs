using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public Venta oVenta { get; set; }
        public int ProductoId { get; set; }
        public Producto oProducto { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }
        public string TransaccionId { get; set; }


    }
}
