using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente oCliente { get; set; }
        public int TotalCompra { get; set; }
        public float MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string TransaccionId { get; set; }
        public List<DetalleVenta> oDetalleVenta { get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
