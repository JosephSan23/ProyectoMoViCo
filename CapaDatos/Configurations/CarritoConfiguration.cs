using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapaDatos.Configurations
{
    public class CarritoConfiguration : IEntityTypeConfiguration<Carrito>
    {
        public void Configure(EntityTypeBuilder<Carrito> builder)
        {
            builder.ToTable("Carrito");

            builder.HasKey(c => c.CarritoId);
            builder.Property(c => c.CarritoId)
                   .HasColumnName("carrito_id")
                   .ValueGeneratedOnAdd();

            builder.HasOne(c => c.oCliente)
               .WithMany()  // Define la navegación inversa si es necesario
               .HasForeignKey(c => c.ClienteId);  // Asegúrate de que la clave foránea se establezca correctamente


            builder.Property(p => p.oProducto);
            //Carrito.HasOne(c => c.oProducto)
            //       .WithMany()
            //       .HasForeignKey("ProductoId");

            builder.Property(c => c.Cantidad)
                   .IsRequired();
        }
    }
}
