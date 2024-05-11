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
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public ConexionContext(DbContextOptions<ConexionContext> options) : base(options) { }

        // Configuraciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //carrito
            modelBuilder.ApplyConfiguration(new CarritoConfiguration());
            //categoria
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            // cliente
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            // detalleventa
            modelBuilder.ApplyConfiguration(new DetalleVentaConfiguration());
            //marca
            modelBuilder.ApplyConfiguration(new MarcaConfiguration());
            //producto
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());
            //usuario
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            //venta
            modelBuilder.ApplyConfiguration(new VentaConfiguration());


            // Aplica otras configuraciones aquí
        }
    }
}
