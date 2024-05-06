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
            builder.ToTable("Clientes");
            builder.HasKey(c => c.ClienteId);
            builder.Property(c => c.ClienteId).ValueGeneratedOnAdd();
            builder.Property(c => c.Nombres).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Apellidos).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Correo).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Contraseña).IsRequired().HasMaxLength(255);
            builder.Property(c => c.RestablecerContraseña).IsRequired().HasDefaultValue(false);
        }
    }
}
