using CapaDatos.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Threading;

namespace CapaDatos
{
    public class ConexionContext : DbContext
    {
        public DbSet<Carrito> Carritos { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<DetalleVenta> DetalleVentas { get; set; }
        //public DbSet<Marca> Marcas { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Venta> Ventas { get; set; }
        public ConexionContext(DbContextOptions<ConexionContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarritoConfiguration());

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());


            // Aplica otras configuraciones aquí
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Carrito>(Carrito =>
        //    {
        //        Carrito.ToTable("Carrito");

        //        Carrito.HasKey(c => c.CarritoId);
        //        Carrito.Property(c => c.CarritoId)
        //               .HasColumnName("carrito_id")
        //               .ValueGeneratedOnAdd();

        //        Carrito.HasOne(c => c.oCliente)
        //               .WithMany() // Aquí defines la navegación inversa si existe
        //               .HasForeignKey("ClienteId"); // Asegúrate de que esta propiedad existe en Cliente

        //        Carrito.Property(p => p.oProducto);
        //        //Carrito.HasOne(c => c.oProducto)
        //        //       .WithMany()
        //        //       .HasForeignKey("ProductoId");

        //        Carrito.Property(c => c.Cantidad)
        //               .IsRequired();

        //    });

        //    modelBuilder.Entity<Cliente>(Cliente =>
        //    {
        //        Cliente.ToTable("Cliente");

        //        Cliente.HasKey(c => c.ClienteId);
        //        Cliente.Property(c => c.ClienteId)
        //               .HasColumnName("cliente_id")
        //               .ValueGeneratedOnAdd();

        //        Cliente.Property(c => c.Nombres)
        //                .IsRequired()
        //                .HasMaxLength(50);

        //        Cliente.Property(c => c.Apellidos)
        //               .IsRequired()
        //               .HasMaxLength(50);

        //        Cliente.Property(c => c.Correo)
        //               .IsRequired()
        //               .HasMaxLength(100);

        //        Cliente.Property(c => c.Contraseña)
        //               .IsRequired()
        //               .HasMaxLength(255);

        //        Cliente.Property(c => c.RestablecerContraseña)
        //               .IsRequired()
        //               .HasDefaultValue(false);

        //    });

        //}

    }
}
