using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nombre de la tabla
            builder.ToTable("Usuario");

            // Clave primaria
            builder.HasKey(u => u.UsuarioId);

            // Configuración de columnas
            builder.Property(u => u.UsuarioId).HasColumnName("id_usuario").ValueGeneratedOnAdd();
            builder.Property(u => u.Nombres).HasColumnName("nombres").HasMaxLength(25).IsRequired();
            builder.Property(u => u.Apellidos).HasColumnName("apellidos").HasMaxLength(25).IsRequired();
            builder.Property(u => u.Correo).HasColumnName("correo").HasMaxLength(60).IsRequired();
            builder.Property(u => u.Contraseña).HasColumnName("clave").HasMaxLength(50).IsRequired();
            builder.Property(u => u.RestablecerContraseña).HasColumnName("restablecer_contraseña").HasDefaultValue(false);
            builder.Property(u => u.Activo).HasColumnName("activo").HasDefaultValue(true);
            builder.Property(u => u.FechaRegistro).HasColumnName("fecha_registro").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
