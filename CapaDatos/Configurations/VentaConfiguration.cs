using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(v => v.VentaId);
            builder.Property(v => v.VentaId).HasColumnName("id_venta").ValueGeneratedOnAdd();

            builder.Property(v => v.ClienteId).HasColumnName("id_cliente").IsRequired();
            builder.HasOne(v => v.oCliente)
                   .WithMany()
                   .HasForeignKey(v => v.ClienteId);

            builder.Property(v => v.TotalCompra).HasColumnName("total_compra");
            builder.Property(v => v.MontoTotal).HasColumnName("MontoTotal").HasColumnType("decimal(10, 2)");

            builder.Property(v => v.Contacto).HasColumnName("Contacto").HasMaxLength(20);
            builder.Property(v => v.Ciudad).HasColumnName("id_distrito").HasMaxLength(10);  // Suponiendo que 'Ciudad' es el distrito
            builder.Property(v => v.Telefono).HasColumnName("telefono").HasMaxLength(50);
            builder.Property(v => v.Direccion).HasColumnName("direccion").HasMaxLength(70);

            builder.Property(v => v.TransaccionId).HasColumnName("id_transaccion").HasMaxLength(15);

            builder.Property(v => v.FechaVenta).HasColumnName("fecha_venta").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
