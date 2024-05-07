using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
     public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
     {
            public void Configure(EntityTypeBuilder<Marca> builder)
            {
                builder.ToTable("Marca");

                // Establece la clave primaria de la tabla y configura la propiedad MarcaId como autoincrementable
                builder.HasKey(m => m.MarcaId);
                builder.Property(m => m.MarcaId)
                       .HasColumnName("id_marca")
                       .ValueGeneratedOnAdd(); // Autoincrementable

                // Configura la propiedad Descripcion con restricciones para ser obligatoria y de longitud máxima de 100 caracteres
                builder.Property(m => m.Descripcion)
                       .HasColumnName("descripcion")
                       .HasMaxLength(100)
                       .IsRequired(); // Asegura que la descripción sea requerida y no exceda 100 caracteres

                // Configura la propiedad Activo con un valor predeterminado
                builder.Property(m => m.Activo)
                       .HasColumnName("activo")
                       .HasDefaultValue(true); // Establece un valor predeterminado

                // Configura la propiedad FechaRegistro para que utilice la fecha y hora actuales del sistema como valor predeterminado
                builder.Property(m => m.FechaRegistro)
                       .HasColumnName("fecha_registro")
                       .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Utiliza la función SQL CURRENT_TIMESTAMP como valor predeterminado
            }
     }
}
