using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");

            builder.HasKey(p => p.ProductoId);
            builder.Property(p => p.ProductoId).HasColumnName("id_producto").ValueGeneratedOnAdd();

            builder.Property(p => p.Nombre).HasColumnName("nombre").HasMaxLength(35).IsRequired();
            builder.Property(p => p.Descripcion).HasColumnName("descripcion").HasMaxLength(100);
            builder.Property(p => p.Precio).HasColumnName("precio").HasColumnType("decimal(10, 2)").HasDefaultValue(0);
            builder.Property(p => p.Stock).HasColumnName("stock");
            builder.Property(p => p.RutaImagen).HasColumnName("ruta_imagen").HasMaxLength(100);
            builder.Property(p => p.NombreImagen).HasColumnName("nombre_imagen").HasMaxLength(100);
            builder.Property(p => p.Activo).HasColumnName("activo").HasDefaultValue(true);
            builder.Property(p => p.FechaRegistro).HasColumnName("fecha_registro").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(p => p.oMarca)
                   .WithMany() // Asumiendo que no necesitas una colección de Productos en Marca
                   .HasForeignKey(p => p.MarcaId)
                   .IsRequired();

            builder.HasOne(p => p.oCategoria)
                   .WithMany() // Asumiendo que no necesitas una colección de Productos en Categoria
                   .HasForeignKey(p => p.CategoriaId)
                   .IsRequired();

            // Relaciones
            //builder.HasOne(p => p.oMarca)
            //       .WithMany(m => m.Productos) // Ahora incluye la colección
            //       .HasForeignKey(p => p.MarcaId);

            //builder.HasOne(p => p.oCategoria)
            //       .WithMany(c => c.Productos) // Ahora incluye la colección
            //       .HasForeignKey(p => p.CategoriaId);
        }
    }
}