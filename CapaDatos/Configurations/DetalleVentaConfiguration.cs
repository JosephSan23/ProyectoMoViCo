using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("Detalle_Venta");  // Especifica el nombre de la tabla

            builder.HasKey(dv => dv.DetalleVentaId);  // Clave primaria
            builder.Property(dv => dv.DetalleVentaId)
                .HasColumnName("id_detalle_venta")
                .ValueGeneratedOnAdd();  // Auto-incremental

            builder.HasOne(dv => dv.oVenta)
                   .WithMany()
                   .HasForeignKey(dv => dv.VentaId);

            builder.HasOne(dv => dv.oProducto)
                   .WithMany()
                   .HasForeignKey(dv => dv.ProductoId);

            builder.Property(dv => dv.cantidad)
                .HasColumnName("cantidad")
                .IsRequired();

            builder.Property(dv => dv.total)
                .HasColumnName("total")
                .HasColumnType("decimal(10, 2)")
                .IsRequired();  // Especifica el tipo de la columna

            builder.Property(dv => dv.TransaccionId)
                .HasColumnName("transaccion_id")
                .IsRequired();  // Asumiendo que quieres agregar esto al esquema
        }
    }
}
