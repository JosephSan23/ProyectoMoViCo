using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.ClienteId);
            builder.Property(c => c.ClienteId)
                .HasColumnName("cliente_id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nombres)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombres");

            builder.Property(c => c.Apellidos)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("apellidos");

            builder.Property(c => c.Correo)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("correo");

            builder.Property(c => c.Contraseña)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("contraseña");

            builder.Property(c => c.RestablecerContraseña)
                .IsRequired()
                .HasDefaultValue(false)
                .HasColumnName("restablecer_contraseña");
        }
    }
}
