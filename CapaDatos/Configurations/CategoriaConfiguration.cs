using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(c => c.CategoriaId);
            builder.Property(c => c.CategoriaId)
                   .HasColumnName("id_categoria")
                   .ValueGeneratedOnAdd(); // Asegura que sea autoincremental

            builder.Property(c => c.Descripcion)
                   .HasColumnName("descripcion")
                   .HasMaxLength(150)
                   .IsRequired(); // Asigna la longitud máxima y marca como requerido

            builder.Property(c => c.Activo)
                   .HasColumnName("activo")
                   .HasDefaultValue(true); // Establece un valor predeterminado

            builder.Property(c => c.FechaRegistro)
                   .HasColumnName("fecha_registro")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Utiliza la función SQL GETDATE() como valor predeterminado
        }
    }
}

