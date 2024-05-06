using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;

namespace CapaDatos
{
    public class ConexionContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public ConexionContext(DbContextOptions<ConexionContext> options) : base(options) { }
    }
}
